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

### How to get a portal subscription?

You can get a portal subscription by either of the following ways:

- One portal add-on is provided along with the purchase of certain type and quantity of Dynamics 365 user license. Details are available in the Dynamics 365 pricing and licensing guide. It is important to note that you get only one portal add-on with user licenses even if you have bought multiple type or quantity of valid licenses.

- Additional portal subscription can be purchased by purchasing Portal Add-on subscription. This subscription is an add-on subscription to Dynamics 365 and is available to be purchased if you have appropriate Dynamics 365 licenses.

### How to change the audience and type of a portal after it is provisioned?

After you have provisioned a portal, the option to change the portal audience is disabled.

However, you can change the audience and type of a portal after it is provisioned by following the steps mentioned in the  [Change the Dynamics 365 instance, audience, or type of portal](change-dynamics-instance.md) article.

### How to change the base URL of a portal after it is provisioned?

You can change the base URL of a portal after it is provisioned by following the steps mentioned in the [Change the base URL of a portal](change-base-url.md) article.

### How to delete a portal completely after it is provisioned?

A Dynamics 365 Portal consists of the following components:

- **Portal website host**: Portal website host is the Portal code which forms the actual website.

- **Portal solutions**: Solutions which are Installed in Dynamics 365 organization and contains the metadata entities for any Dynamics 365 Portal.

To delete a portal completely requires deleting Portal website host as well as uninstalling Portal solutions from your Dynamics 365 organization.

To reset portal host, follow the steps mentioned in the [Reset a portal](reset-portal.md) article. It is important to note that resetting portal host doesn't affect the configuration done in your Dynamics 365 organization.

To delete portal solutions, you will have to delete solutions from Dynamics 365 solution explorer UI, the order in which Portal solutions should be uninstalled is provided [here](https://community.dynamics.com/365/b/dynamics365portalssupport/archive/2017/02/27/portal-troubleshooting-part-three-uninstalling-portal-solutions).

## Dynamics 365 organization lifecycle

###	We recently moved our Dynamics 365 organization from one geolocation or tenant to another. How to handle portals connected to our organization?

When you move your Dynamics 365 organization from one geolocation or tenant to another, associated portals to that organization will not move automatically. Also, since your organization is moved, portal associated to that organization will not work and will throw an error on startup.

To associate your portal again to relevant organization:

1. You must reset your existing portal host from the existing geolocation or tenant by following steps mentioned in the [Reset a portal](reset-portal.md) article. This step will delete your associated portal resources and portal URL will not be accessible after the operation completes.

2. Once your existing portal is reset, you need to go to the new tenant (or to the new geolocation of the existing tenant) and provision a portal available there.

### After restoring Dynamics 365 organization from an old backup, the portal connected to the organization is not working. How to fix it?

When a Dynamics 365 organization is restored from a backup, there are various changes which are done in your organization which can break your portal's connection with the organization. To fix this issue:

- If the organization ID is same after the restore operation and portal solutions are also available:

  1. Go to the Dynamics 365 Administration Center, and then select the **Applications** tab.
  2. Select the name of the portal, and then select **Manage**.
  3. In Portal Admin Center, go to the **Portal Details** tab.
  4. In the **Portal Details** tab, choose **Off** from the **Portal State** drop-down list.
  5. Select **Update**. 
  6. Once the update operation is complete, set the **Portal State** drop-down list to **On**, then select **Update**.

  Your portal will be restarted and connection will be created with the organization again.

- If the organization ID is different after the restore operation or portal solutions are deleted from your organization.

  - In this case, it is better to reset the portal by following steps mentioned in the [Reset a portal](reset-portal.md) article and then reprovision it.

### We recently changed URL of our Dynamics 365 organization and our Portal stopped working. How do we fix it?

When you change URL of your Dynamics 365 organization, your portal will stop working because it cannot identify the Dynamics 365 URL anymore. To fix this issue:

1. Go to the Dynamics 365 Administration Center, and then select the **Applications** tab.
2. Select the name of the portal, and then select **Manage**.
3. Go to **Portal Actions** > **Update Dynamic 365 URL**.
4. Follow the instructions in the wizard.

Your portal will be restarted and start working again.

## Debugging and fixing problems

### When accessing my portal, I see a generic error page. How to see actual error?

Whenever a server error occurs while trying to render a portal, a generic error page is displayed to end-users along with the timestamp and activity ID of the error. Portal administrators can configure their portal to get the actual error details which are helpful in debugging and fixing issues. To see the actual error:

- **Disable custom error page on portal**: This will turn off the custom error page and will allow you to see the complete stack trace of any error when navigating to that page. You can disbale custom error by following steps mentioned in the [Disable custom error](view-portal-error-log.md#disable-custom-error) article.

It is advisable to use this only when you are developing a portal. Once your portal is live for your users, you should enable custom errors again. More information: [View portal error logs](view-portal-error-log.md)

- **Enable diagnostic logging**: This will allow you to get all the portal errors in an Azure Blob storage account. You can enable diagnostic logging by following steps mentioned in the [Access portal error logs](view-portal-error-log.md#access-portal-error-logs) article.

When you enable diagnostic logging, you can search for particular errors which users reported by using the Activity ID shown on the generic error page. The Activity ID is logged along with the error details and is useful to find the actual issue.

## Portal administration and management

### How use a custom login provider on my portal?

Dynamics 365 Portal supports any custom login provider which provides support for standard authentication protocols. We support OpenIdConnect, SAML2, and WS-Federation protocols for any custom IDP. Oauth2 is only supported for a fixed set of known IDPs. For more information on how to set up an IDP configuration, see [Configure Dynamics 365 portal authentication](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/portals/configure-portal-authentication).

### How to get new Portal releases in my sandbox Portal first before it gets applied to production?

Any Portal release is done in two phases: early upgrade and GA. During the early upgrade phase, we only upgrade portals which are marked for early upgrade. To get new Portal release in your sandbox (development or test) environment, you can enable your Portal for early upgrade. For information on how to enable a Portal for early upgrade, see [Upgrade a portal](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/portals/upgrade-portal).

### How to use a custom domain name for my portal?

You can enable your portal to use a custom domain name in place of standard `microsoftcrmportals.com` domain name. More information: [Link your Dynamics 365 portal to a custom domain](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/portals/manage-portal#link-your-dynamics-365-portal-to-a-custom-domain).

## General

### How to redirect a user to a default page after signing-in?

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