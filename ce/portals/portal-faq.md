---
title: "Dynamics 365 Portal FAQ | MicrosoftDocs"
description: "Frequently asked questions in Dynamics 365 Portal."
ms.custom:
  - dyn365-portal
ms.date: 08/29/2018
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
ms.assetid: E68386D7-2015-4F23-A1D4-A69517B37E0D
ms.reviewer: ""
author: sbmjais
ms.author: shjais
manager: shubhadaj
---

# Dynamics 365 Portal FAQ

We have compiled a list of frequently asked questions and provided brief answers to help you get to your information quickly.

## How to change the audience and type of a portal after it is provisioned?

After you have provisioned a portal, the option to change the portal audience is disabled.

However, you can change the audience and type of a portal after it is provisioned by following the steps mentioned in the  [Change the Dynamics 365 instance, audience, or type of portal](change-dynamics-instance.md) article.

## How to change the base URL of a portal after it is provisioned?

You can change the base URL of a portal after it is provisioned by following the steps mentioned in the [Change the base URL of a portal](change-base-url.md) article.

## How to redirect a user to a default page after signing-in?

You can configure a portal to redirect a user to a default page after signing in. To achieve this functionality, you can include a JavaScript code in the Home web template.

For example, if you want to redirect all users to the Forums page after signing in, you can include a JavaScript code in the Home web template as follows:

```xml
{% if user %}
//if any user logs in
<script>
  window.location.href='./forums/'
</script>
{% else %}
//Home web page code, if you don't want to display the page when the user is being redirected
{% endif %}
//Home web page code, if you want to display the page when the user is being redirected
```

For more information on working with Liquid templates, see [Work with Liquid templates](custom-templates-dynamic-content.md).

## How to get a portal subscription?

You can get a portal subscription by either of the following ways:

- One portal add-on is provided along with the purchase of certain type and quantity of Dynamics 365 user license. Details are available in the Dynamics 365 pricing and licensing guide. It is important to note that you get only one portal add-on with user licenses even if you have bought multiple type or quantity of valid licenses.

- Additional portal subscription can be purchased by purchasing Portal Add-on subscription. This subscription is an add-on subscription to Dynamics 365 and is available to be purchased if you have appropriate Dynamics 365 licenses.

## How to delete a portal completely after it is provisioned?

A Dynamics 365 Portal consists of the following components:

- **Portal website host**: Portal website host is the Portal code which forms the actual website.

- **Portal solutions**: Solutions which are Installed in Dynamics 365 organization and contains the metadata entities for any Dynamics 365 Portal.

To delete a portal completely requires deleting Portal website host as well as uninstalling Portal solutions from your Dynamics 365 organization.

To reset portal host, follow the steps listed [here](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/portals/reset-portal). It is important to note that resetting portal host doesn't affect the configuration done in your Dynamics 365 organization.

To delete portal solutions, you will have to delete solutions from Dynamics 365 solution explorer UI, the order in which Portal solutions should be uninstalled is provided [here](https://community.dynamics.com/365/b/dynamics365portalssupport/archive/2017/02/27/portal-troubleshooting-part-three-uninstalling-portal-solutions).  

## How use a custom login provider on my portal?

Dynamics 365 Portal supports any custom login provider which provides support for standard authentication protocols. We support OpenIdConnect, SAML2, and WS-Federation protocols for any custom IDP. Oauth2 is only supported for a fixed set of known IDPs. For more information on how to set up an IDP configuration, see [Configure Dynamics 365 portal authentication](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/portals/configure-portal-authentication).

## How to get new Portal releases in my sandbox Portal first before it gets applied to production?

Any Portal release is done in two phases: early upgrade and GA. During the early upgrade phase, we only upgrade portals which are marked for early upgrade. To get new Portal release in your sandbox (development or test) environment, you can enable your Portal for early upgrade. For information on how to enable a Portal for early upgrade, see [Upgrade a portal](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/portals/upgrade-portal).

## How to use a custom domain name for my portal?

You can enable your portal to use a vanity domain name in place of standard `microsoftcrmportals.com` domain name by following the steps mentioned in the [Link your Dynamics 365 portal to a custom domain](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/portals/manage-portal#link-your-dynamics-365-portal-to-a-custom-domain) article.