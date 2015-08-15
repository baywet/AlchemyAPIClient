$regexPattern = '\[assembly:\s+Assembly(?:File)Version\(\"\d{1,4}\.\d{1,4}\.\d{1,4}\.\d{1,4}\"\)\]';
$assemblyFiles = get-childitem -filter "*AssemblyInfo.cs" -Recurse;
$targetVersionInfo = '[assembly: AssemblyFileVersion ("'+$Env:BUILD_BUILDNUMBER+'")]';
foreach($assemblyFile in $assemblyFiles)
{
    ((get-content $assemblyFile.FullName) -replace $regexPattern, $targetVersionInfo) | Out-File -FilePath $assemblyFile.FullName -Verbose;
}