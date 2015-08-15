param([String]$releaseNotes)
$regexPattern = '<releaseNotes></releaseNotes>';
$assemblyFiles = get-childitem -filter "*AlchemyAPIClient.nuspec" -Recurse;
$targetVersionInfo = '<releaseNotes>'+$releaseNotes+'</releaseNotes>';
foreach($assemblyFile in $assemblyFiles)
{
    ((get-content $assemblyFile.FullName) -replace $regexPattern, $targetVersionInfo) | Out-File -FilePath $assemblyFile.FullName -Verbose;
}