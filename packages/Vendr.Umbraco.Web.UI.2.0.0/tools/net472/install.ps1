param($installPath, $toolsPath, $package, $project)

Write-Host "installPath:" "${installPath}"
Write-Host "toolsPath:" "${toolsPath}"

Write-Host " "

if ($project) {

	$dateTime = Get-Date -Format yyyyMMdd-HHmmss

	# Create paths and list them
	$projectPath = (Get-Item $project.Properties.Item("FullPath").Value).FullName
	Write-Host "projectPath:" "${projectPath}"

	# Copy Vendr files from package to project folder	
	$srcAppPluginPath = Join-Path $installPath "App_Plugins"
	$targetAppPluginPath = Join-Path $projectPath "App_Plugins"

    Write-Host "copying files to $projectPath ..."
	# see https://support.microsoft.com/en-us/help/954404/return-codes-that-are-used-by-the-robocopy-utility-in-windows-server-2
	# Spaces are essential at the end of paths so don't remove them
    robocopy "$srcAppPluginPath " "$targetAppPluginPath " /is /it /e
    if (($lastexitcode -eq 1) -or ($lastexitcode -eq 3) -or ($lastexitcode -eq 5) -or ($lastexitcode -eq 7))
    {
        write-host "Copy succeeded!"
    }
    else
    {
        write-host "Copy failed with exit code:" $lastexitcode
    }
	
	Try 
	{
		# Update client dependency version
		Write-Host "Incrementing client dependency version"
		$clientDependencyConfigSource = Join-Path $projectPath "config\ClientDependency.config"
		Write-Host "clientDependencyConfigSource:" "${clientDependencyConfigSource}"

		$xml = New-Object System.XML.XMLDocument
		$xml.Load($clientDependencyConfigSource)

		Write-Host "Current client dependency version: " $xml.clientDependency.version

		$xml.clientDependency.version = [string](([long]$xml.clientDependency.version) + 1)

		Write-Host "Target client dependency version: " $xml.clientDependency.version

		$utf8WithoutBom = New-Object System.Text.UTF8Encoding($false)
		$sw = New-Object System.IO.StreamWriter($clientDependencyConfigSource, $false, $utf8WithoutBom)
		$xml.Save($sw)
		$sw.Close()

		Write-Host "Client dependency version updated"
	} 
	Catch 
	{
		# Not a big problem if this fails, let it go
		# Write-Host "An error occurred:"
		# Write-Host $_			
	}

	# Open appropriate readme
	# if($copyWebconfig -eq $true)  
	# {
	# 	$DTE.ItemOperations.OpenFile($toolsPath + '\Readme.txt')
	# } 
	# else 
	# {	
	# 	$DTE.ItemOperations.OpenFile($toolsPath + '\ReadmeUpgrade.txt')
	# }

}