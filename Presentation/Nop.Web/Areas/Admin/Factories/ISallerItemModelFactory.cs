using System.Threading.Tasks;
using Nop.Core.Domain.SallerItems;
using Nop.Web.Areas.Admin.Models.Contact;
using Nop.Web.Areas.Admin.Models.SallerItem;
using Nop.Web.Areas.Admin.Models.SallerItem;

namespace Nop.Web.Areas.Admin.Factories
{
    /// <summary>
    /// Represents the SallerItem model factory
    /// </summary>
    public partial interface ISallerItemModelFactory
    {
        /// <summary>
        /// Prepare SallerItem search model
        /// </summary>
        /// <param name="searchModel">SallerItem search model</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the opic search model
        /// </returns>
        Task<SallerItemSearchModel> PrepareSallerItemSearchModelAsync(SallerItemSearchModel searchModel);

        /// <summary>
        /// Prepare paged SallerItem list model
        /// </summary>
        /// <param name="searchModel">SallerItem search model</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the opic list model
        /// </returns>
        Task<SallerItemListModel> PrepareSallerItemListModelAsync(SallerItemSearchModel searchModel);

        /// <summary>
        /// Prepare SallerItem model
        /// </summary>
        /// <param name="model">SallerItem model</param>
        /// <param name="SallerItem">SallerItem</param>
        /// <param name="excludeProperties">Whether to exclude populating of some properties of model</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the opic model
        /// </returns>
        Task<SallerItemModel> PrepareSallerItemModelAsync(SallerItemModel model, SallerItem SallerItem, bool excludeProperties = false);
    }
}