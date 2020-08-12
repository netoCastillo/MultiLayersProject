using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace WebSitePresentationLayer.Helpers
{
    public static class PagingHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="totalItems">Total records number</param>
        /// <param name="indexPage">Index number selected</param>
        /// <param name="sizePaging">Range of records to show</param>
        /// <returns></returns>
        public static IHtmlString PagingHtml(int totalItems, int indexSelected, int sizePaging = 10)
        {
            int iterations = (totalItems / sizePaging)+1;
            int prevValue = indexSelected == 0 ? 0 : (indexSelected - sizePaging);
            int nextvalue = (totalItems - indexSelected) < sizePaging ? indexSelected : (indexSelected + sizePaging)  ;

            iterations += 2; //adding 2 elements to construct prev & next button

            if(iterations > 2)
            {
                TagBuilder nav = new TagBuilder("nav");
                TagBuilder ul = new TagBuilder("ul");
                ul.AddCssClass("pagination");

                StringBuilder links = new StringBuilder();
                for (int i = 0; i < iterations; i++)
                {
                    TagBuilder li = new TagBuilder("li");
                    li.AddCssClass("page-item");

                    TagBuilder _a = new TagBuilder("a");
                    _a.AddCssClass("page-link");
                    if (i == 0)
                    {
                        _a.InnerHtml = "Previous";
                        _a.Attributes.Add("href", "/Home/EmployeePage?indexPage=" + prevValue.ToString());
                    }
                    else
                    {
                        if (i == (iterations - 1))
                        {
                            _a.InnerHtml = "Next";
                            _a.Attributes.Add("href", "/Home/EmployeePage?indexPage=" + nextvalue.ToString());
                        }
                        else
                        {
                            _a.InnerHtml = i.ToString();
                            _a.Attributes.Add("href", "/Home/EmployeePage?indexPage=" + ((i - 1) * sizePaging).ToString());
                        }
                    }                    
                    
                    li.InnerHtml = _a.ToString();
                    links.Append(li.ToString());

                }

                ul.InnerHtml = links.ToString();
                nav.InnerHtml = ul.ToString();
                return new MvcHtmlString(nav.ToString());
            }
           else
               return new MvcHtmlString("");
        }
    }
}