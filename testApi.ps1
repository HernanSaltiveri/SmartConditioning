#######
# 
# this code is meant to test the webapi
#
# not ready
#
#######



$Cred = Get-Credential
$Url = "https://server.contoso.com:8089/services/search/jobs/export"
$Body = @{
    search = "search index=_internal | reverse | table index,host,source,sourcetype,_raw"
    output_mode = "csv"
    earliest_time = "-2d@d"
    latest_time = "-1d@d"
}
Invoke-RestMethod -Method 'Post' -Uri $url -Credential $Cred -Body $body -OutFile output.csv


$RESTAPIServer = "ServerDNSNameOrIPHere"

$RESTAPIUser = "admin"
$RESTAPIPassword = "password"

$Credentials = Get-Credential -Credential $null
$RESTAPIUser = $Credentials.UserName
$Credentials.Password | ConvertFrom-SecureString
$RESTAPIPassword = $Credentials.GetNetworkCredential().password

# Run once to create secure credential file
GET-CREDENTIAL –Credential (Get-Credential) | EXPORT-CLIXML "C:\SecureString\SecureCredentials.xml"
# Run at the start of each script to import the credentials
$Credentials = IMPORT-CLIXML "C:\SecureString\SecureCredentials.xml"
$RESTAPIUser = $Credentials.UserName
$RESTAPIPassword = $Credentials.GetNetworkCredential().Password

add-type @"
    using System.Net;
    using System.Security.Cryptography.X509Certificates;
    public class TrustAllCertsPolicy : ICertificatePolicy {
        public bool CheckValidationResult(
            ServicePoint srvPoint, X509Certificate certificate,
            WebRequest request, int certificateProblem) {
            return true;
        }
    }
"@
[System.Net.ServicePointManager]::CertificatePolicy = New-Object TrustAllCertsPolicy
[System.Net.ServicePointManager]::SecurityProtocol = [System.Net.SecurityProtocolType]'Ssl3,Tls,Tls11,Tls12'

Invoke-RestMethod -SkipCertficiateCheck
Invoke-WebRequest -SkipCertficiateCheck