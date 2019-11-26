---
title: "Authenticate channel users in Dynamics 365 Channel Integration Framework | Microsoft Docs"
description: "Learn how to authenticate channel users in the Dynamics 365 Channel Integration Framework. The Dynamics 365 Channel Integration Framework supports the SAML-based single sign-on (SSO) for your agents or users to log in to the widget (channel)."
author: susikka
ms.author: susikka
manager: shujoshi
ms.date: 10/25/2019
ms.topic: article
ms.service: 
  - dynamics-365-cross-app
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# Authenticate channel users to log in to the channel

Microsoft Dynamics 365 Channel Integration Framework supports the SAML-based single sign-on (SSO) for your users (agents) to sign in to the channel (widget). The SAML-based SSO is available for Dynamics 365 online where the communication widget hosts the channel. To enable SAML-based SSO for the channel (widget), you (an administrator) must register the channel (widget) in the Azure Active Directory portal as a multitenant application, where you have registered the model-driven app.

After you register, the Azure Active Directory administrator must grant access to the channel (widget) to the users (agents).

If you enable SAML-based SSO, the channel (widget) aligns with the model-driven app inactivity timeout period and signs out the users (agents) from both the channel (widget) and Dynamics 365 app such as Dynamics 365 Customer Service and Dynamics 365 Sales.

To enable SSO for the channel (widget), perform the following:

1. Register the third-party widget (channel) in Azure Active Directory.

    a. Enter basic SAML configuration.
    b. Review or customize the claims issued in the SAML token.
    c. Review certificate expiration data, status, and email notification.
    d. Set up the target application.
    e. Assign users and groups to your SAML application.
    f. Test the SAML application.

  For more information on how to register and configure the channel (widget), visit [Configure SSO to applications](https://docs.microsoft.com/azure/active-directory/manage-apps/configure-single-sign-on-non-gallery-applications).

2. Authorize access to Azure Active Directory web applications using the OAuth 2.0 code grant flow.

    a. Request an authorization code.
    b. Use the authorization code to request an access token.
    c. Use the access token to access the resource.
    d. Refresh the access tokens.

  For more information on how to authorize access to Azure Active Directory web applications, visit [OAuth 2.0](https://docs.microsoft.com/azure/active-directory/develop/v1-protocols-oauth-code).

> [!div class="nextstepaction"]
> [Pass Dynamics 365 URL to widget library](pass-url-widget-library.md)

## See Also

[Configure channel provider for your Dynamics 365 organization](configure-channel-provider-channel-integration-framework.md)<br />
[Enable outbound communication (ClickToAct)](enable-outbound-communication-clicktoact.md)<br />
[Add Dynamics 365 Channel Integration Framework solution as a dependent solution](add-cif-solution-dependent-solution.md)<br />
[Pass Dynamics 365 URL to widget library](pass-url-widget-library.md)
