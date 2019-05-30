---
title: "Authenticate channel users in Channel Integration Framework (CIF) | Microsoft Docs"
description: "Learn how to authenticate channel users in the Channel Integration Framework (CIF) for Microsoft Dynamics 365 for Customer Engagement apps. The Channel Integration Framework supports the SAML based Single Sign-On (SSO) for your agents or users to log in to the widget (channel)."
keywords: ""
ms.date: 12/10/2018
ms.service:
  - dynamics-365-cross-app
ms.custom:
  - "dyn365-a11y"
  - "dyn365-developer"
ms.topic: article
applies_to:
  - "Dynamics 365 for Customer Engagement (online)"
  - "Dynamics 365 for Customer Engagement Version 9.x"
ms.assetid: 47B90869-152B-48A6-A249-F37059FF9C12
author: susikka
ms.author: susikka
manager: shujoshi
---

# Authenticate channel users to the log in to the channel

The Dynamics 365 Channel Integration Framework supports the SAML based Single Sign-On (SSO) for your users (agents) to log in to the channel (widget). The SAML based SSO is available for Dynamics 365 online where the communication widget hosts the channel. To enable SAML based SSO for the channel (widget), you must (administrator) register the channel (widget) in the Azure Active Directory portal as a multi-tenant application, where you have registered the Dynamics 365 Unified Interface App.

After you register, the Azure Active Directory administrator must grant access to the channel (widget) to the users (agents).

If you enable SAML based SSO, the channel (widget) aligns with the Dynamics 365 Unified Interface App inactivity timeout period and signs-out the users (agents) from both the channel (widget) and Dynamics 365 Unified Interface App.

To enable SSO for the channel (widget), perform the following:

1. Register the third-party widget (channel) in Azure Active Directory.
    a. Enter basic SAML configuration.
    b. Review or customize the claims issued in the SAML token.
    c. Review certificate expiration data, status, and email notification.
    d. Set up the target application.
    e. Assign users and groups to your SAML application.
    f. Test the SAML application.

For more information on how to register and configure the channel (widget), visit [Configure SSO to applications](https://docs.microsoft.com/en-us/azure/active-directory/manage-apps/configure-single-sign-on-non-gallery-applications).

2. Authorize access to Azure Active Directory web applications using the OAuth 2.0 code grant flow.
    a. Request an authorization code.
    b. Use the authorization code to request an access token.
    c. Use the access token to access the resource.
    d. Refreshing the access tokens.

For more information on how to authorize access to Azure Active Directory web applications, visit [OAuth 2.0](https://docs.microsoft.com/en-us/azure/active-directory/develop/v1-protocols-oauth-code).

> [!div class="nextstepaction"]
> [Pass Dynamics 365 URL to widget library](pass-url-widget-library.md)

## See Also

[Configure channel provider for your Dynamics 365 organization](configure-channel-provider-channel-integration-framework.md)<br />
[Enable outbound communication (ClickToAct)](enable-outbound-communication-clicktoact.md)<br />
[Add Channel Integration Framework solution as a dependent solution](add-cif-solution-dependent-solution.md)<br />
[Pass Dynamics 365 URL to widget library](pass-url-widget-library.md)