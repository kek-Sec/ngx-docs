using ngx_docs_managment_application._Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ngx_docs_managment_application._Controllers
{
    class Images_Controller
    {
        Images_Service img = new Images_Service();

        public void Favicon_btn()
        {
            img.Set_Favicon();
        }

        public void ImagesFolder_btn()
        {
            img.Set_Images_Folder();
        }
    }
}
