// Type: System.Web.Mvc.Controller
// Assembly: System.Web.Mvc, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// Assembly location: C:\Program Files\Microsoft ASP.NET\ASP.NET MVC 3\Assemblies\System.Web.Mvc.dll

using System;
using System.IO;
using System.Security.Principal;
using System.Text;
using System.Web;
using System.Web.Routing;

namespace System.Web.Mvc
{
    /// <summary>
    /// Provides methods that respond to HTTP requests that are made to an ASP.NET MVC Web site.
    /// </summary>
    public abstract class Controller : ControllerBase, IActionFilter, IAuthorizationFilter, IDisposable, IExceptionFilter, IResultFilter
    {
        /// <summary>
        /// Creates a content result object by using a string.
        /// </summary>
        /// 
        /// <returns>
        /// The content result instance.
        /// </returns>
        /// <param name="content">The content to write to the response.</param>
        protected internal ContentResult Content(string content);

        /// <summary>
        /// Creates a content result object by using a string and the content type.
        /// </summary>
        /// 
        /// <returns>
        /// The content result instance.
        /// </returns>
        /// <param name="content">The content to write to the response.</param><param name="contentType">The content type (MIME type).</param>
        protected internal ContentResult Content(string content, string contentType);

        /// <summary>
        /// Creates a content result object by using a string, the content type, and content encoding.
        /// </summary>
        /// 
        /// <returns>
        /// The content result instance.
        /// </returns>
        /// <param name="content">The content to write to the response.</param><param name="contentType">The content type (MIME type).</param><param name="contentEncoding">The content encoding.</param>
        protected internal virtual ContentResult Content(string content, string contentType, Encoding contentEncoding);

        /// <summary>
        /// Creates an action invoker.
        /// </summary>
        /// 
        /// <returns>
        /// An action invoker.
        /// </returns>
        protected virtual IActionInvoker CreateActionInvoker();

        /// <summary>
        /// Creates a temporary data provider.
        /// </summary>
        /// 
        /// <returns>
        /// A temporary data provider.
        /// </returns>
        protected virtual ITempDataProvider CreateTempDataProvider();

        /// <summary>
        /// Releases all resources that are used by the current instance of the <see cref="T:System.Web.Mvc.Controller"/> class.
        /// </summary>
        public void Dispose();

        /// <summary>
        /// Releases unmanaged resources and optionally releases managed resources.
        /// </summary>
        /// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
        protected virtual void Dispose(bool disposing);

        /// <summary>
        /// Invokes the action in the current controller context.
        /// </summary>
        protected override void ExecuteCore();

        /// <summary>
        /// Creates a <see cref="T:System.Web.Mvc.FileContentResult"/> object by using the file contents and file type.
        /// </summary>
        /// 
        /// <returns>
        /// The file-content result object.
        /// </returns>
        /// <param name="fileContents">The binary content to send to the response.</param><param name="contentType">The content type (MIME type).</param>
        protected internal FileContentResult File(byte[] fileContents, string contentType);

        /// <summary>
        /// Creates a <see cref="T:System.Web.Mvc.FileContentResult"/> object by using the file contents, content type, and the destination file name.
        /// </summary>
        /// 
        /// <returns>
        /// The file-content result object.
        /// </returns>
        /// <param name="fileContents">The binary content to send to the response.</param><param name="contentType">The content type (MIME type).</param><param name="fileDownloadName">The file name to use in the file-download dialog box that is displayed in the browser.</param>
        protected internal virtual FileContentResult File(byte[] fileContents, string contentType, string fileDownloadName);

        /// <summary>
        /// Creates a <see cref="T:System.Web.Mvc.FileStreamResult"/> object by using the <see cref="T:System.IO.Stream"/> object and content type.
        /// </summary>
        /// 
        /// <returns>
        /// The file-content result object.
        /// </returns>
        /// <param name="fileStream">The stream to send to the response.</param><param name="contentType">The content type (MIME type).</param>
        protected internal FileStreamResult File(Stream fileStream, string contentType);

        /// <summary>
        /// Creates a <see cref="T:System.Web.Mvc.FileStreamResult"/> object using the <see cref="T:System.IO.Stream"/> object, the content type, and the target file name.
        /// </summary>
        /// 
        /// <returns>
        /// The file-stream result object.
        /// </returns>
        /// <param name="fileStream">The stream to send to the response.</param><param name="contentType">The content type (MIME type)</param><param name="fileDownloadName">The file name to use in the file-download dialog box that is displayed in the browser.</param>
        protected internal virtual FileStreamResult File(Stream fileStream, string contentType, string fileDownloadName);

        /// <summary>
        /// Creates a <see cref="T:System.Web.Mvc.FilePathResult"/> object by using the file name and the content type.
        /// </summary>
        /// 
        /// <returns>
        /// The file-stream result object.
        /// </returns>
        /// <param name="fileName">The path of the file to send to the response.</param><param name="contentType">The content type (MIME type).</param>
        protected internal FilePathResult File(string fileName, string contentType);

        /// <summary>
        /// Creates a <see cref="T:System.Web.Mvc.FilePathResult"/> object by using the file name, the content type, and the file download name.
        /// </summary>
        /// 
        /// <returns>
        /// The file-stream result object.
        /// </returns>
        /// <param name="fileName">The path of the file to send to the response.</param><param name="contentType">The content type (MIME type).</param><param name="fileDownloadName">The file name to use in the file-download dialog box that is displayed in the browser.</param>
        protected internal virtual FilePathResult File(string fileName, string contentType, string fileDownloadName);

        /// <summary>
        /// Called when a request matches this controller, but no method with the specified action name is found in the controller.
        /// </summary>
        /// <param name="actionName">The name of the attempted action.</param>
        protected virtual void HandleUnknownAction(string actionName);

        /// <summary>
        /// Returns an instance of the <see cref="T:System.Web.Mvc.HttpNotFoundResult"/> class.
        /// </summary>
        /// 
        /// <returns>
        /// An instance of the <see cref="T:System.Web.Mvc.HttpNotFoundResult"/> class.
        /// </returns>
        protected internal HttpNotFoundResult HttpNotFound();

        /// <summary>
        /// Returns an instance of the <see cref="T:System.Web.Mvc.HttpNotFoundResult"/> class.
        /// </summary>
        /// 
        /// <returns>
        /// An instance of the <see cref="T:System.Web.Mvc.HttpNotFoundResult"/> class.
        /// </returns>
        /// <param name="statusDescription">The status description.</param>
        protected internal virtual HttpNotFoundResult HttpNotFound(string statusDescription);

        /// <summary>
        /// Creates a <see cref="T:System.Web.Mvc.JavaScriptResult"/> object.
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="T:System.Web.Mvc.JavaScriptResult"/> object that writes the script to the response.
        /// </returns>
        /// <param name="script">The JavaScript code to run on the client</param>
        protected internal virtual JavaScriptResult JavaScript(string script);

        /// <summary>
        /// Creates a <see cref="T:System.Web.Mvc.JsonResult"/> object that serializes the specified object to JavaScript Object Notation (JSON).
        /// </summary>
        /// 
        /// <returns>
        /// The JSON result object that serializes the specified object to JSON format. The result object that is prepared by this method is written to the response by the ASP.NET MVC framework when the object is executed.
        /// </returns>
        /// <param name="data">The JavaScript object graph to serialize.</param>
        protected internal JsonResult Json(object data);

        /// <summary>
        /// Creates a <see cref="T:System.Web.Mvc.JsonResult"/> object that serializes the specified object to JavaScript Object Notation (JSON) format.
        /// </summary>
        /// 
        /// <returns>
        /// The JSON result object that serializes the specified object to JSON format.
        /// </returns>
        /// <param name="data">The JavaScript object graph to serialize.</param><param name="contentType">The content type (MIME type).</param>
        protected internal JsonResult Json(object data, string contentType);

        /// <summary>
        /// Creates a <see cref="T:System.Web.Mvc.JsonResult"/> object that serializes the specified object to JavaScript Object Notation (JSON) format.
        /// </summary>
        /// 
        /// <returns>
        /// The JSON result object that serializes the specified object to JSON format.
        /// </returns>
        /// <param name="data">The JavaScript object graph to serialize.</param><param name="contentType">The content type (MIME type).</param><param name="contentEncoding">The content encoding.</param>
        protected internal virtual JsonResult Json(object data, string contentType, Encoding contentEncoding);

        /// <summary>
        /// Creates a <see cref="T:System.Web.Mvc.JsonResult"/> object that serializes the specified object to JavaScript Object Notation (JSON) format using the specified JSON request behavior.
        /// </summary>
        /// 
        /// <returns>
        /// The result object that serializes the specified object to JSON format.
        /// </returns>
        /// <param name="data">The JavaScript object graph to serialize.</param><param name="behavior">The content type (MIME type).</param>
        protected internal JsonResult Json(object data, JsonRequestBehavior behavior);

        /// <summary>
        /// Creates a <see cref="T:System.Web.Mvc.JsonResult"/> object that serializes the specified object to JavaScript Object Notation (JSON) format using the specified content type and JSON request behavior.
        /// </summary>
        /// 
        /// <returns>
        /// The result object that serializes the specified object to JSON format.
        /// </returns>
        /// <param name="data">The JavaScript object graph to serialize.</param><param name="contentType">The content type (MIME type).</param><param name="behavior">The JSON request behavior</param>
        protected internal JsonResult Json(object data, string contentType, JsonRequestBehavior behavior);

        /// <summary>
        /// Creates a <see cref="T:System.Web.Mvc.JsonResult"/> object that serializes the specified object to JavaScript Object Notation (JSON) format using the content type, content encoding, and the JSON request behavior.
        /// </summary>
        /// 
        /// <returns>
        /// The result object that serializes the specified object to JSON format.
        /// </returns>
        /// <param name="data">The JavaScript object graph to serialize.</param><param name="contentType">The content type (MIME type).</param><param name="contentEncoding">The content encoding.</param><param name="behavior">The JSON request behavior </param>
        protected internal virtual JsonResult Json(object data, string contentType, Encoding contentEncoding, JsonRequestBehavior behavior);

        /// <summary>
        /// Initializes data that might not be available when the constructor is called.
        /// </summary>
        /// <param name="requestContext">The HTTP context and route data.</param>
        protected override void Initialize(RequestContext requestContext);

        /// <summary>
        /// Called before the action method is invoked.
        /// </summary>
        /// <param name="filterContext">Information about the current request and action.</param>
        protected virtual void OnActionExecuting(ActionExecutingContext filterContext);

        /// <summary>
        /// Called after the action method is invoked.
        /// </summary>
        /// <param name="filterContext">Information about the current request and action.</param>
        protected virtual void OnActionExecuted(ActionExecutedContext filterContext);

        /// <summary>
        /// Called when authorization occurs.
        /// </summary>
        /// <param name="filterContext">Information about the current request and action.</param>
        protected virtual void OnAuthorization(AuthorizationContext filterContext);

        /// <summary>
        /// Called when an unhandled exception occurs in the action.
        /// </summary>
        /// <param name="filterContext">Information about the current request and action.</param>
        protected virtual void OnException(ExceptionContext filterContext);

        /// <summary>
        /// Called after the action result that is returned by an action method is executed.
        /// </summary>
        /// <param name="filterContext">Information about the current request and action result</param>
        protected virtual void OnResultExecuted(ResultExecutedContext filterContext);

        /// <summary>
        /// Called before the action result that is returned by an action method is executed.
        /// </summary>
        /// <param name="filterContext">Information about the current request and action result</param>
        protected virtual void OnResultExecuting(ResultExecutingContext filterContext);

        /// <summary>
        /// Creates a <see cref="T:System.Web.Mvc.PartialViewResult"/> object that renders a partial view.
        /// </summary>
        /// 
        /// <returns>
        /// A partial-view result object.
        /// </returns>
        protected internal PartialViewResult PartialView();

        /// <summary>
        /// Creates a <see cref="T:System.Web.Mvc.PartialViewResult"/> object that renders a partial view, by using the specified model.
        /// </summary>
        /// 
        /// <returns>
        /// A partial-view result object.
        /// </returns>
        /// <param name="model">The model that is rendered by the partial view</param>
        protected internal PartialViewResult PartialView(object model);

        /// <summary>
        /// Creates a <see cref="T:System.Web.Mvc.PartialViewResult"/> object that renders a partial view, by using the specified view name.
        /// </summary>
        /// 
        /// <returns>
        /// A partial-view result object.
        /// </returns>
        /// <param name="viewName">The name of the view that is rendered to the response.</param>
        protected internal PartialViewResult PartialView(string viewName);

        /// <summary>
        /// Creates a <see cref="T:System.Web.Mvc.PartialViewResult"/> object that renders a partial view, by using the specified view name and model.
        /// </summary>
        /// 
        /// <returns>
        /// A partial-view result object.
        /// </returns>
        /// <param name="viewName">The name of the view that is rendered to the response.</param><param name="model">The model that is rendered by the partial view</param>
        protected internal virtual PartialViewResult PartialView(string viewName, object model);

        /// <summary>
        /// Creates a <see cref="T:System.Web.Mvc.RedirectResult"/> object that redirects to the specified URL.
        /// </summary>
        /// 
        /// <returns>
        /// The redirect result object.
        /// </returns>
        /// <param name="url">The URL to redirect to.</param>
        protected internal virtual RedirectResult Redirect(string url);

        /// <summary>
        /// Returns an instance of the <see cref="T:System.Web.Mvc.RedirectResult"/> class with the <see cref="P:System.Web.Mvc.RedirectResult.Permanent"/> property set to true.
        /// </summary>
        /// 
        /// <returns>
        /// An instance of the <see cref="T:System.Web.Mvc.RedirectResult"/> class with the <see cref="P:System.Web.Mvc.RedirectResult.Permanent"/> property set to true.
        /// </returns>
        /// <param name="url">The URL to redirect to.</param>
        protected internal virtual RedirectResult RedirectPermanent(string url);

        /// <summary>
        /// Redirects to the specified action using the action name.
        /// </summary>
        /// 
        /// <returns>
        /// The redirect result object.
        /// </returns>
        /// <param name="actionName">The name of the action.</param>
        protected internal RedirectToRouteResult RedirectToAction(string actionName);

        /// <summary>
        /// Redirects to the specified action using the action name and route values.
        /// </summary>
        /// 
        /// <returns>
        /// The redirect result object.
        /// </returns>
        /// <param name="actionName">The name of the action.</param><param name="routeValues">The parameters for a route. </param>
        protected internal RedirectToRouteResult RedirectToAction(string actionName, object routeValues);

        /// <summary>
        /// Redirects to the specified action using the action name and route dictionary.
        /// </summary>
        /// 
        /// <returns>
        /// The redirect result object.
        /// </returns>
        /// <param name="actionName">The name of the action.</param><param name="routeValues">The parameters for a route.</param>
        protected internal RedirectToRouteResult RedirectToAction(string actionName, RouteValueDictionary routeValues);

        /// <summary>
        /// Redirects to the specified action using the action name and controller name.
        /// </summary>
        /// 
        /// <returns>
        /// The redirect result object.
        /// </returns>
        /// <param name="actionName">The name of the action.</param><param name="controllerName">The name of the controller</param>
        protected internal RedirectToRouteResult RedirectToAction(string actionName, string controllerName);

        /// <summary>
        /// Redirects to the specified action using the action name, controller name, and route values.
        /// </summary>
        /// 
        /// <returns>
        /// The redirect result object.
        /// </returns>
        /// <param name="actionName">The name of the action.</param><param name="controllerName">The name of the controller</param><param name="routeValues">The parameters for a route. </param>
        protected internal RedirectToRouteResult RedirectToAction(string actionName, string controllerName, object routeValues);

        /// <summary>
        /// Redirects to the specified action using the action name, controller name, and route dictionary.
        /// </summary>
        /// 
        /// <returns>
        /// The redirect result object.
        /// </returns>
        /// <param name="actionName">The name of the action.</param><param name="controllerName">The name of the controller</param><param name="routeValues">The parameters for a route.</param>
        protected internal virtual RedirectToRouteResult RedirectToAction(string actionName, string controllerName, RouteValueDictionary routeValues);

        /// <summary>
        /// Returns an instance of the <see cref="T:System.Web.Mvc.RedirectResult"/> class with the <see cref="P:System.Web.Mvc.RedirectResult.Permanent"/> property set to true using the specified action name.
        /// </summary>
        /// 
        /// <returns>
        /// An instance of the <see cref="T:System.Web.Mvc.RedirectResult"/> class with the <see cref="P:System.Web.Mvc.RedirectResult.Permanent"/> property set to true using the specified action name, controller name, and route values.
        /// </returns>
        /// <param name="actionName">The action name.</param>
        protected internal RedirectToRouteResult RedirectToActionPermanent(string actionName);

        /// <summary>
        /// Returns an instance of the <see cref="T:System.Web.Mvc.RedirectResult"/> class with the <see cref="P:System.Web.Mvc.RedirectResult.Permanent"/> property set to true using the specified action name, and route values.
        /// </summary>
        /// 
        /// <returns>
        /// An instance of the <see cref="T:System.Web.Mvc.RedirectResult"/> class with the <see cref="P:System.Web.Mvc.RedirectResult.Permanent"/> property set to true using the specified action name, and route values.
        /// </returns>
        /// <param name="actionName">The action name.</param><param name="routeValues">The route values.</param>
        protected internal RedirectToRouteResult RedirectToActionPermanent(string actionName, object routeValues);

        /// <summary>
        /// Returns an instance of the <see cref="T:System.Web.Mvc.RedirectResult"/> class with the <see cref="P:System.Web.Mvc.RedirectResult.Permanent"/> property set to true using the specified action name,  and route values.
        /// </summary>
        /// 
        /// <returns>
        /// An instance of the <see cref="T:System.Web.Mvc.RedirectResult"/> class with the <see cref="P:System.Web.Mvc.RedirectResult.Permanent"/> property set to true using the specified action name,  and route values.
        /// </returns>
        protected internal RedirectToRouteResult RedirectToActionPermanent(string actionName, RouteValueDictionary routeValues);

        /// <summary>
        /// Returns an instance of the <see cref="T:System.Web.Mvc.RedirectResult"/> class with the <see cref="P:System.Web.Mvc.RedirectResult.Permanent"/> property set to true using the specified action name,  and controller name.
        /// </summary>
        /// 
        /// <returns>
        /// An instance of the <see cref="T:System.Web.Mvc.RedirectResult"/> class with the <see cref="P:System.Web.Mvc.RedirectResult.Permanent"/> property set to true using the specified action name,  and controller name.
        /// </returns>
        /// <param name="actionName">The action name.</param><param name="controllerName">The controller name.</param>
        protected internal RedirectToRouteResult RedirectToActionPermanent(string actionName, string controllerName);

        /// <summary>
        /// Returns an instance of the <see cref="T:System.Web.Mvc.RedirectResult"/> class with the <see cref="P:System.Web.Mvc.RedirectResult.Permanent"/> property set to true using the specified action name, controller name, and route values.
        /// </summary>
        /// 
        /// <returns>
        /// An instance of the <see cref="T:System.Web.Mvc.RedirectResult"/> class with the <see cref="P:System.Web.Mvc.RedirectResult.Permanent"/> property set to true.
        /// </returns>
        /// <param name="actionName">The action name.</param><param name="controllerName">The controller name.</param><param name="routeValues">The route values.</param>
        protected internal RedirectToRouteResult RedirectToActionPermanent(string actionName, string controllerName, object routeValues);

        /// <summary>
        /// Returns an instance of the <see cref="T:System.Web.Mvc.RedirectResult"/> class with the <see cref="P:System.Web.Mvc.RedirectResult.Permanent"/> property set to true using the specified action name, controller name, and route values.
        /// </summary>
        /// 
        /// <returns>
        /// An instance of the <see cref="T:System.Web.Mvc.RedirectResult"/> class with the <see cref="P:System.Web.Mvc.RedirectResult.Permanent"/> property set to true using the specified action name, controller name, and route values.
        /// </returns>
        /// <param name="actionName">The action name.</param><param name="controllerName">The controller name.</param><param name="routeValues">The route values.</param>
        protected internal virtual RedirectToRouteResult RedirectToActionPermanent(string actionName, string controllerName, RouteValueDictionary routeValues);

        /// <summary>
        /// Redirects to the specified route using the specified route values.
        /// </summary>
        /// 
        /// <returns>
        /// The redirect-to-route result object.
        /// </returns>
        /// <param name="routeValues">The parameters for a route. </param>
        protected internal RedirectToRouteResult RedirectToRoute(object routeValues);

        /// <summary>
        /// Redirects to the specified route using the route dictionary.
        /// </summary>
        /// 
        /// <returns>
        /// The redirect-to-route result object.
        /// </returns>
        /// <param name="routeValues">The parameters for a route.</param>
        protected internal RedirectToRouteResult RedirectToRoute(RouteValueDictionary routeValues);

        /// <summary>
        /// Redirects to the specified route using the route name.
        /// </summary>
        /// 
        /// <returns>
        /// The redirect-to-route result object.
        /// </returns>
        /// <param name="routeName">The name of the route</param>
        protected internal RedirectToRouteResult RedirectToRoute(string routeName);

        /// <summary>
        /// Redirects to the specified route using the route name and route values.
        /// </summary>
        /// 
        /// <returns>
        /// The redirect-to-route result object.
        /// </returns>
        /// <param name="routeName">The name of the route</param><param name="routeValues">The parameters for a route. </param>
        protected internal RedirectToRouteResult RedirectToRoute(string routeName, object routeValues);

        /// <summary>
        /// Redirects to the specified route using the route name and route dictionary.
        /// </summary>
        /// 
        /// <returns>
        /// The redirect-to-route result object.
        /// </returns>
        /// <param name="routeName">The name of the route</param><param name="routeValues">The parameters for a route.</param>
        protected internal virtual RedirectToRouteResult RedirectToRoute(string routeName, RouteValueDictionary routeValues);

        /// <summary>
        /// Returns an instance of the <see cref="T:System.Web.Mvc.RedirectResult"/> class with the <see cref="P:System.Web.Mvc.RedirectResult.Permanent"/> property set to true using the specified route values.
        /// </summary>
        /// 
        /// <returns>
        /// Returns <see cref="T:System.Web.Mvc.RedirectToRouteResult"/>.
        /// </returns>
        /// <param name="routeValues">The route name.</param>
        protected internal RedirectToRouteResult RedirectToRoutePermanent(object routeValues);

        /// <summary>
        /// Returns an instance of the <see cref="T:System.Web.Mvc.RedirectResult"/> class with the <see cref="P:System.Web.Mvc.RedirectResult.Permanent"/> property set to true using the specified route values.
        /// </summary>
        /// 
        /// <returns>
        /// An instance of the <see cref="T:System.Web.Mvc.RedirectResult"/> class with the <see cref="P:System.Web.Mvc.RedirectResult.Permanent"/> property set to true using the specified route values.
        /// </returns>
        /// <param name="routeValues">The route values.</param>
        protected internal RedirectToRouteResult RedirectToRoutePermanent(RouteValueDictionary routeValues);

        /// <summary>
        /// Returns an instance of the <see cref="T:System.Web.Mvc.RedirectResult"/> class with the <see cref="P:System.Web.Mvc.RedirectResult.Permanent"/> property set to true using the specified route name.
        /// </summary>
        /// 
        /// <returns>
        /// Returns an instance of the <see cref="T:System.Web.Mvc.RedirectResult"/> class with the <see cref="P:System.Web.Mvc.RedirectResult.Permanent"/> property set to true using the specified route name.
        /// </returns>
        /// <param name="routeName">The route name.</param>
        protected internal RedirectToRouteResult RedirectToRoutePermanent(string routeName);

        /// <summary>
        /// Returns an instance of the <see cref="T:System.Web.Mvc.RedirectResult"/> class with the <see cref="P:System.Web.Mvc.RedirectResult.Permanent"/> property set to true using the specified route name and route values.
        /// </summary>
        /// 
        /// <returns>
        /// An instance of the <see cref="T:System.Web.Mvc.RedirectResult"/> class with the <see cref="P:System.Web.Mvc.RedirectResult.Permanent"/> property set to true.
        /// </returns>
        /// <param name="routeName">The route name.</param><param name="routeValues">The route values.</param>
        protected internal RedirectToRouteResult RedirectToRoutePermanent(string routeName, object routeValues);

        /// <summary>
        /// Returns an instance of the <see cref="T:System.Web.Mvc.RedirectResult"/> class with the <see cref="P:System.Web.Mvc.RedirectResult.Permanent"/> property set to true using the specified route name and route values.
        /// </summary>
        /// 
        /// <returns>
        /// An instance of the <see cref="T:System.Web.Mvc.RedirectResult"/> class with the <see cref="P:System.Web.Mvc.RedirectResult.Permanent"/> property set to true using the specified route name and route values.
        /// </returns>
        /// <param name="routeName">The route name.</param><param name="routeValues">The route values.</param>
        protected internal virtual RedirectToRouteResult RedirectToRoutePermanent(string routeName, RouteValueDictionary routeValues);

        /// <summary>
        /// Updates the specified model instance using values from the controller's current value provider.
        /// </summary>
        /// 
        /// <returns>
        /// true if the update is successful; otherwise, false.
        /// </returns>
        /// <param name="model">The model instance to update.</param><typeparam name="TModel">The type of the model object.</typeparam><exception cref="T:System.ArgumentNullException">The <paramref name="model"/> parameter or the <see cref="P:System.Web.Mvc.ControllerBase.ValueProvider"/> property is null.</exception>
        protected internal bool TryUpdateModel<TModel>(TModel model) where TModel : class;

        /// <summary>
        /// Updates the specified model instance using values from the controller's current value provider and a prefix.
        /// </summary>
        /// 
        /// <returns>
        /// true if the update is successful; otherwise, false.
        /// </returns>
        /// <param name="model">The model instance to update.</param><param name="prefix">The prefix to use when looking up values in the value provider.</param><typeparam name="TModel">The type of the model object.</typeparam><exception cref="T:System.ArgumentNullException">The <paramref name="model"/> parameter or the <see cref="P:System.Web.Mvc.ControllerBase.ValueProvider"/> property is null.</exception>
        protected internal bool TryUpdateModel<TModel>(TModel model, string prefix) where TModel : class;

        /// <summary>
        /// Updates the specified model instance using values from the controller's current value provider and included properties.
        /// </summary>
        /// 
        /// <returns>
        /// true if the update is successful; otherwise, false.
        /// </returns>
        /// <param name="model">The model instance to update.</param><param name="includeProperties">A list of properties of the model to update.</param><typeparam name="TModel">The type of the model object.</typeparam><exception cref="T:System.ArgumentNullException">The <paramref name="model"/> parameter or the <see cref="P:System.Web.Mvc.ControllerBase.ValueProvider"/> property is null.</exception>
        protected internal bool TryUpdateModel<TModel>(TModel model, string[] includeProperties) where TModel : class;

        /// <summary>
        /// Updates the specified model instance using values from the controller's current value provider, a prefix, and included properties.
        /// </summary>
        /// 
        /// <returns>
        /// true if the update is successful; otherwise, false.
        /// </returns>
        /// <param name="model">The model instance to update.</param><param name="prefix">The prefix to use when looking up values in the value provider.</param><param name="includeProperties">A list of properties of the model to update.</param><typeparam name="TModel">The type of the model object.</typeparam><exception cref="T:System.ArgumentNullException">The <paramref name="model"/> parameter or the <see cref="P:System.Web.Mvc.ControllerBase.ValueProvider"/> property is null.</exception>
        protected internal bool TryUpdateModel<TModel>(TModel model, string prefix, string[] includeProperties) where TModel : class;

        /// <summary>
        /// Updates the specified model instance using values from the controller's current value provider, a prefix, a list of properties to exclude, and a list of properties to include.
        /// </summary>
        /// 
        /// <returns>
        /// true if the update is successful; otherwise, false.
        /// </returns>
        /// <param name="model">The model instance to update.</param><param name="prefix">The prefix to use when looking up values in the value provider</param><param name="includeProperties">A list of properties of the model to update.</param><param name="excludeProperties">A list of properties to explicitly exclude from the update. These are excluded even if they are listed in the <paramref name="includeProperties"/> parameter list.</param><typeparam name="TModel">The type of the model object.</typeparam><exception cref="T:System.ArgumentNullException">The <paramref name="model"/> parameter or the <see cref="P:System.Web.Mvc.ControllerBase.ValueProvider"/> property is null.</exception>
        protected internal bool TryUpdateModel<TModel>(TModel model, string prefix, string[] includeProperties, string[] excludeProperties) where TModel : class;

        /// <summary>
        /// Updates the specified model instance using values from the value provider.
        /// </summary>
        /// 
        /// <returns>
        /// true if the update is successful; otherwise, false.
        /// </returns>
        /// <param name="model">The model instance to update.</param><param name="valueProvider">A dictionary of values that is used to update the model.</param><typeparam name="TModel">The type of the model object.</typeparam>
        protected internal bool TryUpdateModel<TModel>(TModel model, IValueProvider valueProvider) where TModel : class;

        /// <summary>
        /// Updates the specified model instance using values from the value provider and a prefix.
        /// </summary>
        /// 
        /// <returns>
        /// true if the update is successful; otherwise, false.
        /// </returns>
        /// <param name="model">The model instance to update.</param><param name="prefix">The prefix to use when looking up values in the value provider.</param><param name="valueProvider">A dictionary of values that is used to update the model.</param><typeparam name="TModel">The type of the model object.</typeparam>
        protected internal bool TryUpdateModel<TModel>(TModel model, string prefix, IValueProvider valueProvider) where TModel : class;

        /// <summary>
        /// Updates the specified model instance using values from the value provider and a list of properties to include.
        /// </summary>
        /// 
        /// <returns>
        /// true if the update is successful; otherwise, false.
        /// </returns>
        /// <param name="model">The model instance to update.</param><param name="includeProperties">A list of properties of the model to update.</param><param name="valueProvider">A dictionary of values that is used to update the model.</param><typeparam name="TModel">The type of the model object.</typeparam>
        protected internal bool TryUpdateModel<TModel>(TModel model, string[] includeProperties, IValueProvider valueProvider) where TModel : class;

        /// <summary>
        /// Updates the specified model instance using values from the value provider, a prefix, and included properties.
        /// </summary>
        /// 
        /// <returns>
        /// true if the update is successful; otherwise, false.
        /// </returns>
        /// <param name="model">The model instance to update.</param><param name="prefix">The prefix to use when looking up values in the value provider.</param><param name="includeProperties">A list of properties of the model to update.</param><param name="valueProvider">A dictionary of values that is used to update the model.</param><typeparam name="TModel">The type of the model object.</typeparam>
        protected internal bool TryUpdateModel<TModel>(TModel model, string prefix, string[] includeProperties, IValueProvider valueProvider) where TModel : class;

        /// <summary>
        /// Updates the specified model instance using values from the value provider, a prefix, a list of properties to exclude , and a list of properties to include.
        /// </summary>
        /// 
        /// <returns>
        /// true if the update is successful; otherwise, false.
        /// </returns>
        /// <param name="model">The model instance to update.</param><param name="prefix">The prefix to use when looking up values in the value provider.</param><param name="includeProperties">A list of properties of the model to update.</param><param name="excludeProperties">A list of properties to explicitly exclude from the update. These are excluded even if they are listed in the <paramref name="includeProperties"/> parameter list.</param><param name="valueProvider">A dictionary of values that is used to update the model.</param><typeparam name="TModel">The type of the model object.</typeparam>
        protected internal bool TryUpdateModel<TModel>(TModel model, string prefix, string[] includeProperties, string[] excludeProperties, IValueProvider valueProvider) where TModel : class;

        /// <summary>
        /// Validates the specified model instance.
        /// </summary>
        /// 
        /// <returns>
        /// true if the model validation is successful; otherwise, false.
        /// </returns>
        /// <param name="model">The model instance to validate.</param>
        protected internal bool TryValidateModel(object model);

        /// <summary>
        /// Validates the specified model instance using an HTML prefix.
        /// </summary>
        /// 
        /// <returns>
        /// true if the model validation is successful; otherwise, false.
        /// </returns>
        /// <param name="model">The model to validate.</param><param name="prefix">The prefix to use when looking up values in the model provider.</param>
        protected internal bool TryValidateModel(object model, string prefix);

        /// <summary>
        /// Updates the specified model instance using values from the controller's current value provider.
        /// </summary>
        /// <param name="model">The model instance to update.</param><typeparam name="TModel">The type of the model object.</typeparam><exception cref="T:System.InvalidOperationException">The model was not successfully updated.</exception>
        protected internal void UpdateModel<TModel>(TModel model) where TModel : class;

        /// <summary>
        /// Updates the specified model instance using values from the controller's current value provider and a prefix.
        /// </summary>
        /// <param name="model">The model instance to update.</param><param name="prefix">A prefix to use when looking up values in the value provider.</param><typeparam name="TModel">The type of the model object.</typeparam>
        protected internal void UpdateModel<TModel>(TModel model, string prefix) where TModel : class;

        /// <summary>
        /// Updates the specified model instance using values from the controller object's current value provider.
        /// </summary>
        /// <param name="model">The model instance to update.</param><param name="includeProperties">A list of properties of the model to update.</param><typeparam name="TModel">The type of the model object.</typeparam>
        protected internal void UpdateModel<TModel>(TModel model, string[] includeProperties) where TModel : class;

        /// <summary>
        /// Updates the specified model instance using values from the controller's current value provider, a prefix, and included properties.
        /// </summary>
        /// <param name="model">The model instance to update.</param><param name="prefix">A prefix to use when looking up values in the value provider.</param><param name="includeProperties">A list of properties of the model to update.</param><typeparam name="TModel">The type of the model object.</typeparam>
        protected internal void UpdateModel<TModel>(TModel model, string prefix, string[] includeProperties) where TModel : class;

        /// <summary>
        /// Updates the specified model instance using values from the controller's current value provider, a prefix, a list of properties to exclude, and a list of properties to include.
        /// </summary>
        /// <param name="model">The model instance to update.</param><param name="prefix">A prefix to use when looking up values in the value provider.</param><param name="includeProperties">A list of properties of the model to update.</param><param name="excludeProperties">A list of properties to explicitly exclude from the update. These are excluded even if they are listed in the <paramref name="includeProperties"/> list.</param><typeparam name="TModel">The type of the model object.</typeparam>
        protected internal void UpdateModel<TModel>(TModel model, string prefix, string[] includeProperties, string[] excludeProperties) where TModel : class;

        /// <summary>
        /// Updates the specified model instance using values from the value provider.
        /// </summary>
        /// <param name="model">The model instance to update.</param><param name="valueProvider">A dictionary of values that is used to update the model.</param><typeparam name="TModel">The type of the model object.</typeparam>
        protected internal void UpdateModel<TModel>(TModel model, IValueProvider valueProvider) where TModel : class;

        /// <summary>
        /// Updates the specified model instance using values from the value provider and a prefix.
        /// </summary>
        /// <param name="model">The model instance to update.</param><param name="prefix">The prefix to use when looking up values in the value provider.</param><param name="valueProvider">A dictionary of values that is used to update the model.</param><typeparam name="TModel">The type of the model object.</typeparam>
        protected internal void UpdateModel<TModel>(TModel model, string prefix, IValueProvider valueProvider) where TModel : class;

        /// <summary>
        /// Updates the specified model instance using values from the value provider, a prefix, and a list of properties to include.
        /// </summary>
        /// <param name="model">The model instance to update.</param><param name="includeProperties">A list of properties of the model to update.</param><param name="valueProvider">A dictionary of values that is used to update the model.</param><typeparam name="TModel">The type of the model object.</typeparam>
        protected internal void UpdateModel<TModel>(TModel model, string[] includeProperties, IValueProvider valueProvider) where TModel : class;

        /// <summary>
        /// Updates the specified model instance using values from the value provider, a prefix, and a list of properties to include.
        /// </summary>
        /// <param name="model">The model instance to update.</param><param name="prefix">The prefix to use when looking up values in the value provider.</param><param name="includeProperties">A list of properties of the model to update.</param><param name="valueProvider">A dictionary of values that is used to update the model.</param><typeparam name="TModel">The type of the model object.</typeparam>
        protected internal void UpdateModel<TModel>(TModel model, string prefix, string[] includeProperties, IValueProvider valueProvider) where TModel : class;

        /// <summary>
        /// Updates the specified model instance using values from the value provider, a prefix, a list of properties to exclude, and a list of properties to include.
        /// </summary>
        /// <param name="model">The model instance to update.</param><param name="prefix">The prefix to use when looking up values in the value provider.</param><param name="includeProperties">A list of properties of the model to update.</param><param name="excludeProperties">A list of properties to explicitly exclude from the update. These are excluded even if they are listed in the <paramref name="includeProperties"/> parameter list.</param><param name="valueProvider">A dictionary of values that is used to update the model.</param><typeparam name="TModel">The type of the model object.</typeparam>
        protected internal void UpdateModel<TModel>(TModel model, string prefix, string[] includeProperties, string[] excludeProperties, IValueProvider valueProvider) where TModel : class;

        /// <summary>
        /// Validates the specified model instance.
        /// </summary>
        /// <param name="model">The model to validate.</param>
        protected internal void ValidateModel(object model);

        /// <summary>
        /// Validates the specified model instance using an HTML prefix.
        /// </summary>
        /// <param name="model">The model to validate.</param><param name="prefix">The prefix to use when looking up values in the model provider.</param>
        protected internal void ValidateModel(object model, string prefix);

        /// <summary>
        /// Creates a <see cref="T:System.Web.Mvc.ViewResult"/> object that renders a view to the response.
        /// </summary>
        /// 
        /// <returns>
        /// The view result that renders a view to the response.
        /// </returns>
        protected internal ViewResult View();

        /// <summary>
        /// Creates a <see cref="T:System.Web.Mvc.ViewResult"/> object by using the model that renders a view to the response.
        /// </summary>
        /// 
        /// <returns>
        /// The view result.
        /// </returns>
        /// <param name="model">The model that is rendered by the view.</param>
        protected internal ViewResult View(object model);

        /// <summary>
        /// Creates a <see cref="T:System.Web.Mvc.ViewResult"/> object by using the view name that renders a view.
        /// </summary>
        /// 
        /// <returns>
        /// The view result.
        /// </returns>
        /// <param name="viewName">The name of the view that is rendered to the response.</param>
        protected internal ViewResult View(string viewName);

        /// <summary>
        /// Creates a <see cref="T:System.Web.Mvc.ViewResult"/> object using the view name and master-page name that renders a view to the response.
        /// </summary>
        /// 
        /// <returns>
        /// The view result.
        /// </returns>
        /// <param name="viewName">The name of the view that is rendered to the response.</param><param name="masterName">The name of the master page or template to use when the view is rendered.</param>
        protected internal ViewResult View(string viewName, string masterName);

        /// <summary>
        /// Creates a <see cref="T:System.Web.Mvc.ViewResult"/> object by using the view name and model that renders a view to the response.
        /// </summary>
        /// 
        /// <returns>
        /// The view result.
        /// </returns>
        /// <param name="viewName">The name of the view that is rendered to the response.</param><param name="model">The model that is rendered by the view.</param>
        protected internal ViewResult View(string viewName, object model);

        /// <summary>
        /// Creates a <see cref="T:System.Web.Mvc.ViewResult"/> object using the view name, master-page name, and model that renders a view.
        /// </summary>
        /// 
        /// <returns>
        /// The view result.
        /// </returns>
        /// <param name="viewName">The name of the view that is rendered to the response.</param><param name="masterName">The name of the master page or template to use when the view is rendered.</param><param name="model">The model that is rendered by the view.</param>
        protected internal virtual ViewResult View(string viewName, string masterName, object model);

        /// <summary>
        /// Creates a <see cref="T:System.Web.Mvc.ViewResult"/> object that renders the specified <see cref="T:System.Web.Mvc.IView"/> object.
        /// </summary>
        /// 
        /// <returns>
        /// The view result.
        /// </returns>
        /// <param name="view">The view that is rendered to the response.</param>
        protected internal ViewResult View(IView view);

        /// <summary>
        /// Creates a <see cref="T:System.Web.Mvc.ViewResult"/> object that renders the specified <see cref="T:System.Web.Mvc.IView"/> object.
        /// </summary>
        /// 
        /// <returns>
        /// The view result.
        /// </returns>
        /// <param name="view">The view that is rendered to the response.</param><param name="model">The model that is rendered by the view.</param>
        protected internal virtual ViewResult View(IView view, object model);

        /// <summary>
        /// This API supports the ASP.NET MVC infrastructure and is not intended to be used directly from your code. This method calls the <see cref="M:System.Web.Mvc.Controller.OnActionExecuting(System.Web.Mvc.ActionExecutingContext)"/> method.
        /// </summary>
        /// <param name="filterContext">The filter context.</param>
        void IActionFilter.OnActionExecuting(ActionExecutingContext filterContext);

        /// <summary>
        /// This API supports the ASP.NET MVC infrastructure and is not intended to be used directly from your code. This method calls the <see cref="M:System.Web.Mvc.Controller.OnActionExecuted(System.Web.Mvc.ActionExecutedContext)"/> method.
        /// </summary>
        /// <param name="filterContext">The filter context.</param>
        void IActionFilter.OnActionExecuted(ActionExecutedContext filterContext);

        /// <summary>
        /// This API supports the ASP.NET MVC infrastructure and is not intended to be used directly from your code. This method calls the <see cref="M:System.Web.Mvc.Controller.OnAuthorization(System.Web.Mvc.AuthorizationContext)"/> method.
        /// </summary>
        /// <param name="filterContext">The filter context.</param>
        void IAuthorizationFilter.OnAuthorization(AuthorizationContext filterContext);

        /// <summary>
        /// This API supports the ASP.NET MVC infrastructure and is not intended to be used directly from your code. This method calls the <see cref="M:System.Web.Mvc.Controller.OnException(System.Web.Mvc.ExceptionContext)"/> method.
        /// </summary>
        /// <param name="filterContext">The filter context.</param>
        void IExceptionFilter.OnException(ExceptionContext filterContext);

        /// <summary>
        /// This API supports the ASP.NET MVC infrastructure and is not intended to be used directly from your code. This method calls the <see cref="M:System.Web.Mvc.Controller.OnResultExecuting(System.Web.Mvc.ResultExecutingContext)"/> method.
        /// </summary>
        /// <param name="filterContext">The filter context.</param>
        void IResultFilter.OnResultExecuting(ResultExecutingContext filterContext);

        /// <summary>
        /// This API supports the ASP.NET MVC infrastructure and is not intended to be used directly from your code. This method calls the <see cref="M:System.Web.Mvc.Controller.OnResultExecuted(System.Web.Mvc.ResultExecutedContext)"/> method.
        /// </summary>
        /// <param name="filterContext">The filter context.</param>
        void IResultFilter.OnResultExecuted(ResultExecutedContext filterContext);

        /// <summary>
        /// Gets the action invoker for the controller.
        /// </summary>
        /// 
        /// <returns>
        /// The action invoker.
        /// </returns>
        public IActionInvoker ActionInvoker { get; set; }

        /// <summary>
        /// Gets or sets the binder.
        /// </summary>
        /// 
        /// <returns>
        /// The binder.
        /// </returns>
        protected internal ModelBinderDictionary Binders { get; set; }

        /// <summary>
        /// Gets HTTP-specific information about an individual HTTP request.
        /// </summary>
        /// 
        /// <returns>
        /// The HTTP context.
        /// </returns>
        public HttpContextBase HttpContext { get; }

        /// <summary>
        /// Gets the model state dictionary object that contains the state of the model and of model-binding validation.
        /// </summary>
        /// 
        /// <returns>
        /// The model state dictionary.
        /// </returns>
        public ModelStateDictionary ModelState { get; }

        /// <summary>
        /// Gets the <see cref="T:System.Web.HttpRequestBase"/> object for the current HTTP request.
        /// </summary>
        /// 
        /// <returns>
        /// The request object.
        /// </returns>
        public HttpRequestBase Request { get; }

        /// <summary>
        /// Gets the <see cref="T:System.Web.HttpResponseBase"/> object for the current HTTP response.
        /// </summary>
        /// 
        /// <returns>
        /// The response object.
        /// </returns>
        public HttpResponseBase Response { get; }

        /// <summary>
        /// Gets the route data for the current request.
        /// </summary>
        /// 
        /// <returns>
        /// The route data.
        /// </returns>
        public RouteData RouteData { get; }

        /// <summary>
        /// Gets the <see cref="T:System.Web.HttpServerUtilityBase"/> object that provides methods that are used during Web request processing.
        /// </summary>
        /// 
        /// <returns>
        /// The HTTP server object.
        /// </returns>
        public HttpServerUtilityBase Server { get; }

        /// <summary>
        /// Gets the <see cref="T:System.Web.HttpSessionStateBase"/> object for the current HTTP request.
        /// </summary>
        /// 
        /// <returns>
        /// The HTTP session-state object for the current HTTP request.
        /// </returns>
        public HttpSessionStateBase Session { get; }

        /// <summary>
        /// Gets the temporary-data provider object that is used to store data for the next request.
        /// </summary>
        /// 
        /// <returns>
        /// The temporary-data provider.
        /// </returns>
        public ITempDataProvider TempDataProvider { get; set; }

        /// <summary>
        /// Gets the URL helper object that is used to generate URLs by using routing.
        /// </summary>
        /// 
        /// <returns>
        /// The URL helper object.
        /// </returns>
        public UrlHelper Url { get; set; }

        /// <summary>
        /// Gets the user security information for the current HTTP request.
        /// </summary>
        /// 
        /// <returns>
        /// The user security information for the current HTTP request.
        /// </returns>
        public IPrincipal User { get; }
    }
}
