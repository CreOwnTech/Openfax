using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenFax.Classes
{
    public class Constants
    {
        public const string ACCOUNT_XML_PATH = "\\Data\\OpenFaxAccount.xml";
        public const string ACCOUNT_IMAGETYPE_TIFF = "Multipage TIFF";
        public const string ACCOUNT_IMAGETYPE_PDF = "PDF";
        public const string LOG_XML_PATH = "\\Data\\OpenfaxLog.xml";
        public const string LOG_XML_FaxDocJpegURL = "FaxDocJpegURL";
        public const string LOG_XML_FaxDocTiffURL = "FaxDocTiffURL";
        public const string LOG_XML_FaxDocPDFURL = "FaxDocPDFURL";
        public const string LOG_XML_FaxImageFile = "faximagefile";

        public const string DIDCONFIG_XML_PATH = "\\Data\\DIDConfiguration.xml";
        public const string DIDCONFIG_XML_POLL = "poll";
        public const string DIDCONFIG_XML_TYPE = "type";
        public const string DIDCONFIG_XML_IMAGESAVEPATH = "filepath";
        public const string DIDCONFIG_XML_SUFFIX = "suffix";
        public const string DIDCONFIG_XML_PREFIX = "prefix";
        public const string DIDCONFIG_XML_ISSUFFIX = "issuffix";
        public const string DIDCONFIG_XML_ISPREFIX = "isprefix";
        public const string DIDCONFIG_XML_D = "d";
        public const string DIDCONFIG_XML_ISDEFAULT = "isdefault";

        public const string DIDCONFIG_COLUMN_POLL = "Poll";
        public const string DIDCONFIG_COLUMN_ISDEFAULT = "IsDefault";
        public const string DIDCONFIG_COLUMN_DID = "DID";
        public const string DIDCONFIG_COLUMN_NAME = "DIDName";
        public const string DIDCONFIG_COLUMN_TYPE = "Type";
        public const string DIDCONFIG_COLUMN_FILEPATH = "FilePath";
        public const string DIDCONFIG_COLUMN_PREFIX = "Prefix";
        public const string DIDCONFIG_COLUMN_SUFFIX = "Suffix";
        public const string DIDCONFIG_COLUMN_D = "D";
        public const string DIDCONFIG_COLUMN_E = "E";
        public const string DIDCONFIG_COLUMN_P = "P";
        public const string DIDCONFIG_COLUMN_S = "S";
        public const string DIDCONFIG_COLUMN_SELECTED = "Select";

        public const string MULTIDIDCONFIG_TITLE = "Multi-DID Configuration";

        public const string NEWFAX_APIURL = "https://api.openfax.com/getNewFax.php";
        public const string NEWFAX_QUERYPARAM_ACCOUNTID = "AccountID";
        public const string NEWFAX_QUERYPARAM_APIKEY = "APIKey";
        public const string NEWFAX_QUERYPARAM_FAXTYPE = "FaxType";
        public const string NEWFAX_QUERYPARAM_LIMIT = "Limit";
        public const string NEWFAX_QUERYPARAM_DID = "DID";
        public const string NEWFAX_APPCONFIG_FAXLIMIT = "FaxDownloadLimit";
        public const string NEWFAX_APPCONFIG_DIDPREFIX = "DIDAddPreFix";

        public const string NEWFAX_NOFAXRECEIVED = "NoNewFaxReceived";

        public const string FAX_READUNREAD_APIURL = "https://api.openfax.com/inboundReadUnread.php";
        public const string FAX_READUNREAD_QUERYPARAM_FROMTRANSID = "FromInTransID";
        public const string FAX_READUNREAD_QUERYPARAM_TOTRANSID = "ToInTransID";
        public const string FAX_READUNREAD_QUERYPARAM_READUNREADFLAG = "ReadUnreadFlag";

        public const string DID_APIURL = "https://api.openfax.com/getAccountDIDS.php";

        public const string VERSION_APIURL = "https://api.openfax.com/checkVersion.php";

        //Messagebox Messages
        public const string ACCOUNT_MESSAGE_TESTSUCCESSFUL = "Your API key is properly configured.";
        public const string ACCOUNT_MESSAGETITLE_TESTSUCCESSFUL = "Test Successful";
        public const string ACCOUNT_MESSAGE_TESTFAILED = "Your Account Number or API key are incorrect. Please review your credentials.";
        public const string ACCOUNT_MESSAGETITLE_TESTFAILED = "Test Failed";

        public const string ACCOUNT_WHEREAPILINK = "Your API key cab be found in your Account Settings at https://portal.openfax.com";
        public const string ACCOUNT_WHEREAPILINKTITLE = "API key";

        public const string ACCOUNT_SAVEALL = "You have updated your default configuration and it will be applied to all DIDS using the default settings.";
        public const string ACCOUNT_SAVEALLTITLE = "API key";

        public const string ACCOUNT_VALIDATIONERROR1 = "Please enter account details.";
        public const string ACCOUNT_VALIDATIONERROR2 = "Either Account Number or API keys are empty.";
        public const string ACCOUNT_VALIDATIONERROR_TITLE = "Account details Empty";

        public const string ACCOUNT_IMAGESAVE_VALIDATIONERROR = "Please enter Image save path.";
        public const string ACCOUNT_IMAGESAVE_VALIDATIONERROR_TITLE = "Account details Empty";

    }
}
