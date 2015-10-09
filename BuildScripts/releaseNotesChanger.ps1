param([String]$releaseNotes)
function getCleanBuildNumber()
{
	$regex = [Regex]"(?<buildnumber>\d{1,4}\.\d{1,4}\.\d{1,4}\.\d{1,4})";
	$match = $regex.Match($Env:BUILD_BUILDNUMBER);
	return $match.Groups["buildnumber"].Value;
}
$buildNumber = getCleanBuildNumber;
$regexPatternNotes = '<releaseNotes></releaseNotes>';
$regexPatternVersion = '<version>.*</version>';
$assemblyFiles = get-childitem -filter "*AlchemyAPIClient.nuspec" -Recurse;
$targetNotesnInfo = '<releaseNotes>'+$releaseNotes+'</releaseNotes>';
$targetVersionInfo = '<version>'+$buildNumber+'</version>';
foreach($assemblyFile in $assemblyFiles)
{
    (((get-content $assemblyFile.FullName) -replace $regexPatternNotes, $targetNotesnInfo) -replace $regexPatternVersion, $targetVersionInfo) | Out-File -FilePath $assemblyFile.FullName -Encoding utf8 -Verbose;
}