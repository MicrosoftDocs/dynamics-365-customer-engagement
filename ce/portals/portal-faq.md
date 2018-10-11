---
title: "Dynamics 365 Portal FAQ | MicrosoftDocs"
description: "Frequently asked questions in Dynamics 365 Portal."
ms.custom: 
  - dyn365-portal
ms.date: 9/25/2018
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
ms.assetid: E68386D7-2015-4F23-A1D4-A69517B37E0D
ms.reviewer: ""
author: sbmjais
ms.author: shjais
manager: shubhadaj
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Portals
---

# Dynamics 365 Portal FAQ

We have compiled a list of frequently asked questions and provided brief answers to help you get to your information quickly.

## Licensing and provisioning

### How do I get a portal subscription?

You can get a portal subscription by either of the following ways:

- One portal add-on is provided along with the purchase of a certain type and quantity of Dynamics 365 user license. Details are available in the Dynamics 365 pricing and licensing guide. It is important to note that you get only one portal add-on with user licenses even if you have bought multiple type or quantity of valid licenses.

- Additional portal subscriptions can be purchased by purchasing a Portal Add-on subscription. This subscription is an add-on subscription to Dynamics 365 and is available to be purchased if you have the appropriate Dynamics 365 licenses.

### How do I change the audience and type of a portal after it is provisioned?

After you have provisioned a portal, the option to change the portal audience is disabled.

However, you can change the audience and type of portal after it is provisioned by following the steps in [Change the Dynamics 365 instance, audience, or type of portal](change-dynamics-instance.md).

### How do I change the base URL of a portal after it is provisioned?

You can change the base URL of a portal after it is provisioned by following the steps in [Change the base URL of a portal](change-base-url.md).

### How do I delete a portal completely after it is provisioned?

A Dynamics 365 Portal consists of the following components:

- **Portal website host**: Portal website host is the Portal code that forms the actual website.

- **Portal solutions**: Solutions that are installed in the Dynamics 365 organization and contain the metadata entities for any Dynamics 365 Portal.

To delete a portal completely requires deleting the Portal website host as well as uninstalling Portal solutions from your Dynamics 365 organization.

To reset the portal host, follow the steps in [Reset a portal](reset-portal.md). It is important to note that resetting a portal host doesn't affect the configuration done in your Dynamics 365 organization.

To delete portal solutions, you will have to delete solutions from the Dynamics 365 solution explorer UI. The order in which Portal solutions should be uninstalled is provided in [Uninstalling Portal Solutions](https://community.dynamics.com/365/b/dynamics365portalssupport/archive/2017/02/27/portal-troubleshooting-part-three-uninstalling-portal-solutions).

## Dynamics 365 organization lifecycle

### We recently moved our Dynamics 365 organization from one geolocation or tenant to another. How do we handle portals connected to our organization?

When you move your Dynamics 365 organization from one geolocation or tenant to another, associated portals to that organization will not move automatically. Also, since your organization has moved, any portal associated with that organization will not work and will throw an error on startup.

To associate your portal again to relevant organizations:

1. Reset your existing portal host from the existing geolocation or tenant by following the steps in [Reset a portal](reset-portal.md). This will delete your associated portal resources and the portal URL will not be accessible after the operation completes.

2. Once your existing portal is reset, go to the new tenant (or to the new geolocation of the existing tenant) and provision a portal available there.

### After restoring a Dynamics 365 organization from an old backup, the portal connected to the organization is not working. How do we fix it?

When a Dynamics 365 organization is restored from a backup, various changes are done in your organization that can break your portal's connection with the organization. To fix this issue:

- If the organization ID is the same after the restore operation and portal solutions are also available:

  1. Go to the Dynamics 365 admin center and select the **Applications** tab.
  2. Select the name of the portal and then select **Manage**.
  3. In Portal Admin Center, go to the **Portal Details** tab.
  4. In the **Portal State** drop-down list, choose **Off**.
  5. Select **Update**. 
  6. Once the update operation is complete, set the **Portal State** drop-down list to **On** and then select **Update**.

  Your portal will be restarted and a connection will be created with the organization again.

- If the organization ID is different after the restore operation or portal solutions are deleted from your organization:

  - In this case, it is better to reset the portal by following the steps in [Reset a portal](reset-portal.md) and then reprovision it.

### We recently changed the URL of our Dynamics 365 organization and our portal stopped working. How do we fix it?

When you change the URL of your Dynamics 365 organization, your portal will stop working because it cannot identify the Dynamics 365 URL anymore. To fix this issue:

1. Go to the Dynamics 365 admin center and select the **Applications** tab.
2. Select the name of the portal and then select **Manage**.
3. Go to **Portal Actions** > **Update Dynamics 365 URL**.
4. Follow the instructions in the wizard.

Your portal will be restarted and start working again.

## Debugging and fixing problems

### When accessing my portal, I see a generic error page. How can I see the actual error?

Whenever a server error occurs while trying to render a portal, a generic error page is displayed to end users along with the timestamp and activity ID of the error. Portal administrators can configure their portal to get the actual error details, which are helpful in debugging and fixing issues. To see the actual error:


<!--from editor: In the sentence below, "You can disable the customer error ..." Do you mean customer error page? Also, the article link doesn't seem to work.-->


- **Disable the custom error page on the portal**: This will turn off the custom error page and will allow you to see the complete stack trace of any error when navigating to that page. You can disable the custom error by following the steps in [Disable custom error](view-portal-error-log.md#disable-custom-error).

It is advisable to use this only when you are developing a portal. Once your portal is live for your users, you should enable custom errors again. More information: [View portal error logs](view-portal-error-log.md)

- **Enable diagnostic logging**: This will allow you to get all the portal errors in an Azure Blob storage account. You can enable diagnostic logging by following the steps in [Access portal error logs](view-portal-error-log.md#access-portal-error-logs).

When you enable diagnostic logging, you can search for particular errors that users report by using the Activity ID shown on the generic error page. The Activity ID is logged along with the error details and is useful to find the actual issue.

## Portal administration and management

### How do I use a custom login provider on my portal?

Dynamics 365 Portal supports any custom login provider that provides support for standard authentication protocols. We support OpenIdConnect, SAML2, and WS-Federation protocols for any custom IDP. OAuth 2 is supported only for a fixed set of known IDPs. For more information on how to set up an IDP configuration, see [Configure Dynamics 365 portal authentication](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/portals/configure-portal-authentication).

### How do I get new portal releases in my sandbox portal first before it gets applied to production?

Any portal release is done in two phases: early upgrade and general availability (GA). During the early upgrade phase, we only upgrade portals that are marked for early upgrade. To get a new portal release in your sandbox (development or test) environment, you can enable your portal for early upgrade. For information on how to enable a portal for early upgrade, see [Upgrade a portal](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/portals/upgrade-portal).

### How do I use a custom domain name for my portal?

You can enable your portal to use a custom domain name in place of the standard `microsoftcrmportals.com` domain name. More information: [Link your Dynamics 365 portal to a custom domain](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/portals/manage-portal#link-your-dynamics-365-portal-to-a-custom-domain)

## General

### How do I redirect a user to a default page after signing in?

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
