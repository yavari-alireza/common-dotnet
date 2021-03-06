﻿
using Appson.Common.General.Utils;
using Appson.Common.Web.Owin.RequestScopeContext;
using Appson.Composer;
using Microsoft.Owin;

namespace Appson.Common.Web.Owin.Composer
{
    public static class ComposerOwinContextExtensions
    {
        private const string ComposerKey = "Appson.Composer";
        private const string ComponentContextKey = "Appson.ComponentContext";

        #region Retrieve methods

        public static IComposer GetComposer(this IOwinContext context)
        {
            return context?.Get<IComposer>(ComposerKey);
        }

        public static IComposer GetComposer(this OwinRequestScopeContext context)
        {
            return context.IfNotNull(c => c.OwinContext.GetComposer());
        }

        public static IComponentContext GetComponentContext(this IOwinContext context)
        {
            return context?.Get<IComponentContext>(ComponentContextKey);
        }

        public static IComponentContext GetComponentContext(this OwinRequestScopeContext context)
        {
            return context.IfNotNull(c => c.OwinContext.GetComponentContext());
        }

        #endregion

        #region Set methods

        public static void SetComposer(this IOwinContext context, IComposer composer)
        {
            context.Set(ComposerKey, composer);
        }

        public static void SetComposer(this OwinRequestScopeContext context, IComposer composer)
        {
            context.OwinContext.SetComposer(composer);
        }

        public static void SetComponentContext(this IOwinContext context, IComponentContext componentContext)
        {
            context.Set(ComponentContextKey, componentContext);
        }

        public static void SetComponentContext(this OwinRequestScopeContext context, IComponentContext componentContext)
        {
            context.OwinContext.SetComponentContext(componentContext);
        }

        #endregion

    }
}
