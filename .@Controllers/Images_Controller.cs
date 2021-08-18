using ngx_docs_managment_application._Services;


namespace ngx_docs_managment_application._Controllers
{
    class Images_Controller
    {
        Images_Service img = new Images_Service();

        /// <summary>
        /// Set favicon button handler
        /// </summary>
        public void Favicon_btn()
        {
            img.Set_Favicon();
        }


        /// <summary>
        /// Set images folder button handler
        /// </summary>
        public void ImagesFolder_btn()
        {
            img.Set_Images_Folder();
        }
    }
}
