Microsoft Dynamics 365 Channel Integration Framework supports the SAML-based single sign-on (SSO) for your users (agents) to sign in to the channel (widget). The SAML-based SSO is available for Dynamics 365 online where the communication widget hosts the channel. To enable SAML-based SSO for the channel (widget), you (an administrator) must register the channel (widget) in the Microsoft Entra ID portal as a multitenant application, where you have registered the model-driven app.

After you register, the Microsoft Entra ID administrator must grant access to the channel (widget) to the users (agents).

If you enable SAML-based SSO, the channel (widget) aligns with the model-driven app inactivity timeout period and signs out the users (agents) from both the channel (widget) and Dynamics 365 app such as Dynamics 365 Customer Service and Dynamics 365 Sales.

## Enable SSO for the channel (widget)

1. Register the third-party widget (channel) in Microsoft Entra ID.

    a. Enter basic SAML configuration.
    
    b. Review or customize the claims issued in the SAML token.
    
    c. Review certificate expiration data, status, and email notification.
    
    d. Set up the target application.
    
    e. Assign users and groups to your SAML application.
    
    f. Test the SAML application.

      More information: [Configure SSO to applications](/azure/active-directory/manage-apps/configure-single-sign-on-non-gallery-applications)

2. Authorize access to Microsoft Entra ID web applications using the OAuth 2.0 code grant flow.

    a. Request an authorization code.
    
    b. Use the authorization code to request an access token.
    
    c. Use the access token to access the resource.
    
    d. Refresh the access tokens.

      More information: [OAuth 2.0](/azure/active-directory/develop/v1-protocols-oauth-code)