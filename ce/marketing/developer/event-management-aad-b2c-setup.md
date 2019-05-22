---
title: "Set up event eanagement to work with AAD B2C Build | MicrosoftDocs"
description: "Provides information about how you can set up event management  web application to work with AAD B2C."
ms.custom:
  - dyn365-developer
  - dyn365-marketing
ms.date: 02/21/2019
ms.service: dynamics-365-marketing
ms.technology: 
  - "marketing"
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
author: tohomanms
ms.author: tohoman
manager: dariosap
---

# Overview

The event portal is capable of integrating the Azure Active Directory B2C. To integrate it you need to implement a couple of steps. 

1. If you don't have one already, create Azure AD B2C tenant
1. Add a web application to your Azure AD B2C tenant
1. Register the application with your CRM instance
1. Configure event management application to work with your Azure AD B2C tenant

# Creating Azure AD B2C tenant and adding a web application to the tenant
For your purposes you can follow quick start tutorial that explains how to create a new Azure AD B2C tenant here: [Create an Azure AD B2C tenant](https://docs.microsoft.com/en-us/azure/active-directory-b2c/tutorial-create-tenant)

After you have sucessfully created Azure AD B2C tenant you can follow this tutorial to add a web application to the newly created tenant:
[Register a web application](https://docs.microsoft.com/en-us/azure/active-directory-b2c/tutorial-register-applications)

> [!NOTE]
> To use a name-based contact matching strategy, you need to configure the sign-up policy to include the `Given Name` and `Surname` attributes and also selecting them in the `Application claim` section.

Detailed information about configuring Azure AD B2C tenant can be found here: [How to configure and set it up in the Azure AD B2C](https://docs.microsoft.com/en-us/azure/active-directory-b2c/)

# Naming

To reduce the clutter while navigating Azure portal we will use the following naming for the portal screens:
* B2C Tenant : **Tenant**
* B2C Tenant > Azure AD B2C Settings: **Settings**
* B2C Tenant > Azure AD B2C Settings > Application > Select your application: **Application**
* Application > Application Id textbox: **Application id** (it is a GUID)
* Tenant > Properties > Name textbox: **Tenant name** (e.g. 'contosoeventmanagementtest.onmicrosoft.com')
* First part of the tenant name: **Tenant id** (e.g. 'contosoeventmanagementtest')
* Settings > User Flows (policies): **Policy** (e.g. 'B2C_1_default-sign-up')
* Application > Published scopes > Full scope value textbox: **Scope** (e.g. 'https://contosoeventmanagementtest.onmicrosoft.com/events/registration')

# Registering the application with CRM instance
According to the defined naming assemble your AAD metadata endpoint following this pattern: 'https://{tenant id}.b2clogin.com/{tenant id}.onmicrosoft.com/v2.0/.well-known/openid-configuration?p={policy}'

With given examples AAD metadata endpoint would be: 'https://contosoeventmanagementtest.b2clogin.com/contosoeventmanagementtest.onmicrosoft.com/v2.0/.well-known/openid-configuration?p=B2C_1_default-sign-up'

With that follow next steps:

1. Open your CRM instance
1. Go to **Dynamics 365 > Marketing > Settings > Web applications** and select the created **Web application** record.
1. Insert your **Application id** in the **AAD Client ID** field.
1. Insert your metadata endpoint in the **AAD Metadata Endpoint** field.
1. Save the changes.


    > [!NOTE]
    > It can take up to 10 minutes until the changes become active.

# Configuring event management application

Open the `environment.ts` configuration file located in the **\src\environments** folder and enter all required values in the `aadB2cConfig` variable.

Use following mapping while entering the values:

* authorityHost: {tenant id}.b2clogin.com (e.g. 'contosoeventmanagementtest.b2clogin.com')
* tenant: Tenant name (e.g. 'contosoeventmanagementtest.onmicrosoft.com')
* clientID: Application id 
* signUpSignInPolicy: Policy (e.g. 'B2C_1_default-sign-up')
* b2cScopes: ['Scope'] (e.g. ['https://contosoeventmanagementtest.onmicrosoft.com/events/registration'])
* redirectUri: Application > Reply URL > Pick your application uri (e.g. for localhost 'http://localhost:4200')

An example of full aadB2cConfig object would be:

```
aadB2CConfig: {
    authorityHost: 'contosoeventmanagementtest.b2clogin.com',
    tenant: 'contosoeventmanagementtest.onmicrosoft.com',
    clientID: '971ff1c7-c5bc-4ac9-90a3-3a363db7ea2d',
    signUpSignInPolicy: 'B2C_1_default-sign-up',
    b2cScopes: ['https://contosoeventmanagementtest.onmicrosoft.com/events/registration'],
    redirectUri: 'http://localhost:4200'
}
```