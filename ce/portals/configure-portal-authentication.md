---
title: "Configure portal authentication in Dynamics 365  | MicrosoftDocs"
description: "Learn about how to configure authentication for a portal."
ms.custom:
  - dyn365-portal
ms.date: 09/28/2017
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
ms.assetid: 1e771204-164a-4fbc-b0a1-89f7a59924c3
ms.reviewer: ""
author: sbmjais
ms.author: shjais
manager: sakudes
---
# Configure Dynamics 365 portal authentication

In a portal application, an authenticated portal user is associated with either a [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] contact or system user. The default portals configuration is contact-based. To log in, a contact must have the appropriate web authentication information configured. Portal users must be assigned to a web roles to gain permissions beyond unauthenticated users. To configure permissions for a web role, configure its webpage access and website access control rules.

The latest portal authentication experience allows portal users to sign in with their choice of a local contact membership provider based account or an external account based on [ASP.NET Identity](http://www.asp.net/identity).   

- **Local authentication**: Local authentication is the common forms-based authentication uses the contact records of a [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] organization for authentication. To build custom authentication experiences, developers can use the ASP.Net Identity API to create custom login pages and tools.
- **External authentication**: External authentication is provided by the ASP.NET Identity API. In this case, account credentials and password management are handled by a third-party identity provider. This includes OpenID based providers such as Yahoo! and Google and OAuth 2.0 based providers such as Twitter, Facebook, and [!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)]. Users sign up to the portal by selecting an external identity to register with the portal. After it is registered, an external identity has access to the same features as a local account. 

Both local and external account registration can use invitation codes for sign up, as well as the email confirmation workflow. In addition, portal administrators may choose to enable or disable any combination of authentication options through portal site settings.

## Account sign-up (registration)

Portal administrators have several options for controlling account sign-up behavior. Open registration is the least restrictive sign-up configuration where the portal allows a user account to be registered by simply providing a user identity. Alternative configurations may require users to provide an invitation code or valid email address to register with the portal. Regardless of the registration configuration, both local and external accounts participate equally in the registration workflow. That is, users have the option to choose which type of account they want to register.

## Open registration

During sign-up, the user has the option of creating a local account (providing a username and password) or selecting an external identity from a list of identity providers. If an external identity is selected, the user is required to sign in through the chosen identity provider to prove that they own the external account. In either case, the user is immediately registered and authenticated with the portal. A new contact record is created in the [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] organization upon sign-up.

With open registration enabled, users are not required to provide an invitation code to complete the sign-up process.

### See also

[Set authentication identity for a portal](set-authentication-identity.md)  
[Define entity forms and custom logic within the Dynamics 365 portal](entity-forms-custom-logic.md)<br>
[Configure a contact for use on a portal](configure-contacts.md)  
[Invite contacts to your portals](invite-contacts.md)  
