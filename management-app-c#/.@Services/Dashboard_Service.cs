using ngx_docs_managment_application._Forms;
using ngx_docs_managment_application._Services;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ngx_docs_managment_application._Controllers
{
    class Dashboard_Service
    {
        readonly Settings_Service settings = new Settings_Service();


        /// <summary>
        /// Verify that folder path is set and exists
        /// </summary>
        /// <returns>True if folder exists false if folder does not exist</returns>
        public bool VerifyProjectFolder()
        {
            try
            {


                string folder_path = settings.getSetting("project_path");

                if (string.IsNullOrEmpty(folder_path)) { return false; }

                if (string.IsNullOrWhiteSpace(folder_path)) { return false; }

                if (!Directory.Exists(folder_path)) { return false; }

                if(!File.Exists(folder_path + "\\package.json")){ return false; }

                Logger_Service.Add("DASHBOARD_SERVICE|VerifyProjectFolder", "Folder verified!");

                return true;
            }
            catch (Exception e)
            {
                Logger_Service.Add("DASHBOARD_SERVICE|VerifyProjectFolder", e.Message);
                return false;
            }
        }

        /// <summary>
        /// Function to generate sample input.json
        /// </summary>
        public void GenerateSampleInput()
        {
            if (!confirmation("Overwrite input.json?")) { return; }
            string folder_path = settings.getSetting("project_path");
            string sample_file = "WwogIHsKICAgICJpZCI6IDAsCiAgICAiVGl0bGUiOiAiTWFyY2hhbnRpb3BoeXRhIiwKICAgICJEZXNjcmlwdGlvbiI6ICJUaGUgTWFyY2hhbnRpb3BoeXRhICgvbcmRy5Byy4xrw6ZudGnLiMmSZsmqdMmZLCAtb8qKy4hmYcmqdMmZLyAoQWJvdXQgdGhpcyBzb3VuZGxpc3RlbikpIGFyZSBhIGRpdmlzaW9uIG9mIG5vbi12YXNjdWxhciBsYW5kIHBsYW50cyBjb21tb25seSByZWZlcnJlZCB0byBhcyBoZXBhdGljcyBvciBsaXZlcndvcnRzLiBMaWtlIG1vc3NlcyBhbmQgaG9ybndvcnRzLCB0aGV5IGhhdmUgYSBnYW1ldG9waHl0ZS1kb21pbmFudCBsaWZlIGN5Y2xlLCBpbiB3aGljaCBjZWxscyBvZiB0aGUgcGxhbnQgY2Fycnkgb25seSBhIHNpbmdsZSBzZXQgb2YgZ2VuZXRpYyBpbmZvcm1hdGlvbi4iLAogICAgInRleHQiOiAiTW9zdCBsaXZlcndvcnRzIGFyZSBzbWFsbCwgbWVhc3VyaW5nIGZyb20gMuKAkzIwIG1pbGxpbWV0cmVzICgwLjA44oCTMC44IGluKSB3aWRlIHdpdGggaW5kaXZpZHVhbCBwbGFudHMgbGVzcyB0aGFuIDEwIGNlbnRpbWV0cmVzICg0IGluKSBsb25nLFs2XSBzbyB0aGV5IGFyZSBvZnRlbiBvdmVybG9va2VkLiBUaGUgbW9zdCBmYW1pbGlhciBsaXZlcndvcnRzIGNvbnNpc3Qgb2YgYSBwcm9zdHJhdGUsIGZsYXR0ZW5lZCwgcmliYm9uLWxpa2Ugb3IgYnJhbmNoaW5nIHN0cnVjdHVyZSBjYWxsZWQgYSB0aGFsbHVzIChwbGFudCBib2R5KTsgdGhlc2UgbGl2ZXJ3b3J0cyBhcmUgdGVybWVkIHRoYWxsb3NlIGxpdmVyd29ydHMuIEhvd2V2ZXIsIG1vc3QgbGl2ZXJ3b3J0cyBwcm9kdWNlIGZsYXR0ZW5lZCBzdGVtcyB3aXRoIG92ZXJsYXBwaW5nIHNjYWxlcyBvciBsZWF2ZXMgaW4gdHdvIG9yIG1vcmUgcmFua3MsIHRoZSBtaWRkbGUgcmFuayBpcyBvZnRlbiBjb25zcGljdW91c2x5IGRpZmZlcmVudCBmcm9tIHRoZSBvdXRlciByYW5rczsgdGhlc2UgYXJlIGNhbGxlZCBsZWFmeSBsaXZlcndvcnRzIG9yIHNjYWxlIGxpdmVyd29ydHMuWzddWzhdIChTZWUgdGhlIGdhbGxlcnkgYmVsb3cgZm9yIGV4YW1wbGVzLikiLAogICAgImltYWdlIjogImFzc2V0cy9pbWFnZXMvZGVmYXVsdC5wbmciLAogICAgIml0ZW1zIjogWwogICAgICAiVGhlIGxpZmUgb2YgYSBsaXZlcndvcnQgc3RhcnRzIGZyb20gdGhlIGdlcm1pbmF0aW9uIG9mIGEgaGFwbG9pZCBzcG9yZSB0byBwcm9kdWNlIGEgcHJvdG9uZW1hLCB3aGljaCBpcyBlaXRoZXIgYSBtYXNzIG9mIHRocmVhZC1saWtlIGZpbGFtZW50cyBvciBlbHNlIGEgZmxhdHRlbmVkIHRoYWxsdXMuWzE1XVsxNl0gVGhlIHByb3RvbmVtYSBpcyBhIHRyYW5zaXRvcnkgc3RhZ2UgaW4gdGhlIGxpZmUgb2YgYSBsaXZlcndvcnQsIGZyb20gd2hpY2ggd2lsbCBncm93IHRoZSBtYXR1cmUgZ2FtZXRvcGhvcmUgKFwiZ2FtZXRlLWJlYXJlclwiKSBwbGFudCB0aGF0IHByb2R1Y2VzIHRoZSBzZXggb3JnYW5zLiBUaGUgbWFsZSBvcmdhbnMgYXJlIGtub3duIGFzIGFudGhlcmlkaWEgKHNpbmd1bGFyOiBhbnRoZXJpZGl1bSkgYW5kIHByb2R1Y2UgdGhlIHNwZXJtIGNlbGxzLiBDbHVzdGVycyBvZiBhbnRoZXJpZGlhIGFyZSBlbmNsb3NlZCBieSBhIHByb3RlY3RpdmUgbGF5ZXIgb2YgY2VsbHMgY2FsbGVkIHRoZSBwZXJpZ29uaXVtIChwbHVyYWw6IHBlcmlnb25pYSkuIEFzIGluIG90aGVyIGxhbmQgcGxhbnRzLCB0aGUgZmVtYWxlIG9yZ2FucyBhcmUga25vd24gYXMgYXJjaGVnb25pYSAoc2luZ3VsYXI6IGFyY2hlZ29uaXVtKSBhbmQgYXJlIHByb3RlY3RlZCBieSB0aGUgdGhpbiBzdXJyb3VuZGluZyBwZXJpY2hhZXR1bSAocGx1cmFsOiBwZXJpY2hhZXRhKS5bOF0gRWFjaCBhcmNoZWdvbml1bSBoYXMgYSBzbGVuZGVyIGhvbGxvdyB0dWJlLCB0aGUgXCJuZWNrXCIsIGRvd24gd2hpY2ggdGhlIHNwZXJtIHN3aW0gdG8gcmVhY2ggdGhlIGVnZyBjZWxsLiIKICAgIF0sCiAgICAidGFncyI6IFsKICAgICAgIk1hcmNoYW50aW9waHl0YSIKICAgIF0sCiAgICAidXJsIjogImh0dHBzOi8vZW4ud2lraXBlZGlhLm9yZy93aWtpL01hcmNoYW50aW9waHl0YSIKICB9LAogIHsKICAgICJpZCI6IDEsCiAgICAiVGl0bGUiOiAiQmxhc2lhbGVzIiwKICAgICJEZXNjcmlwdGlvbiI6ICJCbGFzaWFsZXMgaXMgYW4gb3JkZXIgb2YgbGl2ZXJ3b3J0cyB3aXRoIGEgc2luZ2xlIGxpdmluZyBmYW1pbHkgYW5kIHR3byBzcGVjaWVzLiBUaGUgb3JkZXIgaGFzIHRyYWRpdGlvbmFsbHkgYmVlbiBjbGFzc2lmaWVkIGFtb25nIHRoZSBNZXR6Z2VyaWFsZXMsIGJ1dCBtb2xlY3VsYXIgY2xhZGlzdGljcyBzdWdnZXN0cyBhIHBsYWNlbWVudCBhdCB0aGUgYmFzZSBvZiB0aGUgTWFyY2hhbnRpb3BzaWRhLiIsCiAgICAiaW1hZ2UiOiAiYXNzZXRzL2ltYWdlcy9kZWZhdWx0LlBORyIsCiAgICAidXJsIjogImh0dHBzOi8vZW4ud2lraXBlZGlhLm9yZy93aWtpL01hcmNoYW50aW9waHl0YSIKICB9LAogIHsKICAgICJpZCI6IDIsCiAgICAiVGl0bGUiOiAiSW5kaWFuIHJvbGxlciIsCiAgICAiRGVzY3JpcHRpb24iOiAiVGhlIEluZGlhbiByb2xsZXIgKENvcmFjaWFzIGJlbmdoYWxlbnNpcykgaXMgYSBiaXJkIG9mIHRoZSBmYW1pbHkgQ29yYWNpaWRhZS4gSXQgaXMgMzDigJMzNCBjbSAoMTLigJMxMyBpbikgbG9uZyB3aXRoIGEgd2luZ3NwYW4gb2YgNjXigJM3NCBjbSAoMjbigJMyOSBpbikgYW5kIHdlaWdocyAxNjbigJMxNzYgZyAoNS454oCTNi4yIG96KS4gVGhlIGZhY2UgYW5kIHRocm9hdCBhcmUgcGlua2lzaCwgdGhlIGhlYWQgYW5kIGJhY2sgYXJlIGJyb3duLCB3aXRoIGJsdWUgb24gdGhlIHJ1bXAgYW5kIGNvbnRyYXN0aW5nIGxpZ2h0IGFuZCBkYXJrIGJsdWUgb24gdGhlIHdpbmdzIGFuZCB0YWlsLiBUaGUgYnJpZ2h0IGJsdWUgbWFya2luZ3Mgb24gdGhlIHdpbmcgYXJlIHByb21pbmVudCBpbiBmbGlnaHQuIFRoZSBzZXhlcyBhcmUgc2ltaWxhciBpbiBhcHBlYXJhbmNlLiBUd28gc3Vic3BlY2llcyBhcmUgcmVjb2duaXNlZC4iLAogICAgInRleHQiOiAiVGhlIEluZGlhbiByb2xsZXIgd2FzIG9uZSBvZiB0aGUgbWFueSBiaXJkIHNwZWNpZXMgb3JpZ2luYWxseSBkZXNjcmliZWQgYnkgQ2FybCBMaW5uYWV1cyBpbiB0aGUgMTc1OCAxMHRoIGVkaXRpb24gb2YgU3lzdGVtYSBOYXR1cmFlLCB3aGVyZSBoZSBjb2luZWQgdGhlIGJpbm9taWFsIG5hbWUgQ29ydnVzIGJlbmdoYWxlbnNpcy5bMl0gTGlubmFldXMgYmFzZWQgaGlzIGRlc2NyaXB0aW9uIG9uIHRoZSBcIkpheSBmcm9tIEJlbmdhbFwiIGRlc2NyaWJlZCBhbmQgaWxsdXN0cmF0ZWQgaW4gMTczMSBieSB0aGUgRW5nbGlzaCBuYXR1cmFsaXN0IEVsZWF6YXIgQWxiaW4sIGRlcml2ZWQgZnJvbSBhIGRyYXdpbmcgYnkgaWxsdXN0cmF0b3IgSm9zZXBoIERhbmRyaWRnZS5bM10iLAogICAgImltYWdlIjogImFzc2V0cy9pbWFnZXMvZGVmYXVsdC5QTkciLAogICAgIml0ZW1zIjogWwogICAgICAiQy4gYi4gYmVuZ2hhbGVuc2lzIChMaW5uYWV1cywgMTc1OCkgb2NjdXJzIGZyb20gd2VzdGVybiBBc2lhIHRvIEluZGlhIG5vcnRoIG9mIHRoZSBWaW5kaHlhIFJhbmdlLls5XVxyXG4iLAogICAgICAiQy4gYi4gaW5kaWN1cyBMaW5uYWV1cywgMTc2NiBvY2N1cnMgaW4gY2VudHJhbCBhbmQgc291dGhlcm4gSW5kaWEgYW5kIGluIFNyaSBMYW5rYS5bOV0gSXQgaXMgZGlzdGluZ3Vpc2hlZCBieSBpdHMgc2xpZ2h0bHkgc2hvcnRlciB3aW5nIGFuZCB0YWlsLCBkYXJrZXIgYmx1ZSBjcm93biBhbmQgdXBwZXIgd2luZyBjb3ZlcnRzLCBtb3JlIGJyb3duaXNoIG1hbnRsZSBhbmQgc2hvdWxkZXIsIGFuZCBtb3JlIHByb25vdW5jZWQgcmVkLWJyb3duIGNvbGxhciBvbiBoaW5kbmVjay5bMTBdXHJcbiIKICAgIF0sCiAgICAidXJsIjogImh0dHBzOi8vZW4ud2lraXBlZGlhLm9yZy93aWtpL01hcmNoYW50aW9waHl0YSIKICB9Cl0=";
            byte[] data = Convert.FromBase64String(sample_file);
            string decodedString = Encoding.UTF8.GetString(data);
            File.WriteAllText(folder_path + "\\src\\input.json", decodedString);
            return;
        }

        /// <summary>
        /// Function to generate sample settings.json
        /// </summary>
        public void GenerateSampleSettings()
        {
            if (!confirmation("Overwrite settings.json?")) { return; }
            string folder_path = settings.getSetting("project_path");
            string sample_file = "WwogICAgewogICAgICAicHJldmlld19zaG93X3BpY3R1cmUiOiB0cnVlLAogICAgICAicHJldmlld19zaG93X3RpdGxlIjogdHJ1ZSwKICAgICAgInByZXZpZXdfc2hvd19kZXNjcmlwdGlvbiI6IHRydWUsCiAgICAgICJwcmV2aWV3X3Nob3dfdGV4dCI6IHRydWUsCiAgICAgICJwcmV2aWV3X3Nob3dfaXRlbXMiOiB0cnVlLAogICAgICAicHJldmlld19zaG93X3VybCI6IGZhbHNlLAogICAgICAicHJldmlld19zaG93X2FsYnVtIjogZmFsc2UsCiAgICAgICJwcmV2aWV3X3Nob3dfdGFncyI6IGZhbHNlLAogICAgICAicHJldmlld19kZXNjcmlwdGlvbl90ZXh0X2xlbmd0aCIgOiAxNSwKICAgICAgInByZXZpZXdfdGV4dF9sZW5ndGgiOiAxNSwKICAgICAgInByZXZpZXdfaXRlbV90ZXh0X2xlbmd0aCI6IDUsCiAgICAgICJwcmV2aWV3X2l0ZW1zX2NvdW50IjogMiwKICAgICAgInByZXZpZXdfbnVtYmVyX29mX2NvbHVtbnMiOiA0CiAgICB9Cl0=";
            byte[] data = Convert.FromBase64String(sample_file);
            string decodedString = Encoding.UTF8.GetString(data);
            File.WriteAllText(folder_path + "\\src\\settings.json", decodedString);
            return;
        }


        /// <summary>
        /// Simple confirmation messagebox
        /// </summary>
        /// <param name="message">The message to display</param>
        /// <returns></returns>
        private bool confirmation(string message)
        {
            DialogResult dr = MessageBox.Show(message, "Are you sure?", MessageBoxButtons.YesNoCancel,
        MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                return true;
            }

            return false;
        }
    }
}
