using System;
using System.Diagnostics;
using System.IO;

namespace WebsiteDeployHelper
{
    class DeployConfig
    {
        public static readonly string DirCurrent = Environment.CurrentDirectory;
        public static readonly string DirConfig = DirCurrent + @"\WebsiteDeployHelper.conf";
        public static readonly string DirLocalPathToUpload = DirCurrent + @"\PowerPointLabs_upload";
        public static readonly string DirAppFilesToUpload = DirCurrent + @"\PowerPointLabs_upload\Application Files";

        public string ConfigDirUpload;
        public string ConfigReleaseType;
        public string ConfigSftpAddress;
        public string ConfigSftpUser;
        public string ConfigDevPath;
        public string ConfigReleasePath;

        public void VerifyConfig()
        {
            if (ConfigReleaseType != "release" && ConfigReleaseType != "dev")
            {
                Util.DisplayWarning(TextCollection.Const.ErrorInvalidConfig + " Release type not correct.", new Exception());
            }
        }
    }
}
