param([String]$releaseNotes)
$regexPatternNotes = '<releaseNotes></releaseNotes>';
$regexPatternVersion = '<version></version>';
$assemblyFiles = get-childitem -filter "*AlchemyAPIClient.nuspec" -Recurse;
$targetNotesnInfo = '<releaseNotes>'+$releaseNotes+'</releaseNotes>';
$targetVersionInfo = '<version>'+$Env:BUILD_BUILDNUMBER+'</version>';
foreach($assemblyFile in $assemblyFiles)
{
    (((get-content $assemblyFile.FullName) -replace $regexPatternNotes, $targetNotesnInfo) -replace $regexPatternVersion, $targetVersionInfo) | Out-File -FilePath $assemblyFile.FullName -Verbose;
}