$scriptPath = split-path -parent $MyInvocation.MyCommand.Definition
$ConnectorPath = "$scriptPath\FieldPROConnector"
$DllPath = "$ConnectorPath\bin\debug"
$ohome = $Env:OCEAN2013HOME
$Packager = "$ohome\PluginPackager.exe" 
$Petrel = "$ohome\petrel.exe" 

Remove-Item -path "$ConnectorPath\plugin.xml" -ErrorAction SilentlyContinue
& $Packager /g "$DllPath\FieldPROConnector.dll" "$ConnectorPath\plugin.xml"
& $Packager /m "$ConnectorPath\plugin.xml" "$Petrel" "$DllPath\"

$cleandir = "$scriptPath\FIELDPRO_PIP\obj\copytemp"
Remove-Item -path $cleandir -recurse -ErrorAction SilentlyContinue
$deploy = "$scriptPath\FIELDPRO_PIP\DeployCopier.exe"
$deployxml = "$scriptPath\FIELDPRO_PIP\DeployList.xml"
$deploytmp = "$scriptPath\FIELDPRO_PIP\obj\copytemp"
& $deploy "$deployxml" "$deploytmp" /config:Debug /platform:"Any CPU"
& $Packager /p "$cleandir\FieldPROConnector.dll" "$scriptPath\FIELDPRO_PIP\bin\Debug\FIELDPRO_PIP.pip"
echo Done!