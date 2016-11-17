// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api
{
    using sys = System;

    using Dropbox.Api.Stone;
    using Dropbox.Api.Auth.Routes;

    public sealed partial class DropboxAppClient
    {
        /// <summary>
        /// <para>Gets the Auth routes.</para>
        /// </summary>
        public AuthAppRoutes Auth { get; private set; }

        /// <summary>
        /// <para>Initializes the routes.</para>
        /// </summary>
        /// <returns>The transport.</returns>
        private void InitializeRoutes(ITransport transport)
        {
            this.Auth = new AuthAppRoutes(transport);
        }
    }
}
