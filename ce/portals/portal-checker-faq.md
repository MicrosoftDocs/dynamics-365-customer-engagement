---
title: "Mitigation steps to the issues logged by the portal checker tool in Dynamics 365 for Customer Engagement Portal | MicrosoftDocs"
description: "Learn the mitigation steps to the issues logged by the portal checker tool."
ms.custom: 
  - dyn365-portal
ms.date: 01/31/2019
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
ms.assetid: F7807673-978E-4097-B4CC-767DDCC2447C
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

# Common portal issues and best practices

This document outlines common issues which can occur in your portal and cause a variety of problems. This also contains the checks which the portal checker (self-service diagnostics) tool automates and warns customers about.

## Portal does not load and displays a generic error page (Server Error in "/" application) 

This issue can be caused by a variety of reasons like when a portal is not able to connect to the underlying [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] organization, [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] organization doesn't exist or its URL has changed, when request to [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] organization is timed out, and so on. When you run the portal checker tool, it will try to determine the exact reason and will point you to the correct mitigation. 

Below is a list of most common causes and their correspondng mitigation steps:

### URL of the connected Dynamics 365 for Customer Engagement organization has changed 

This happens when the URL of [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] organization is changed by a user after portal is provisioned against the organization. To fix this issue, update the Dynamics 365 URL:

1. Go to the Dynamics 365 Administration Center page and select the **Applications** tab.
2. Select the name of the portal that you want to reset, and then select **Manage**.
3. Go to **Portal Actions** > **Update Dynamics 365 URL**. Once this action is successfully executed, your Dynamics 365 organization URL will be updated and portal will start working.

### Dynamics 365 organization connected to your portal is in administration mode

This issue occurs when the [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] organization is put in administration mode either when changing organization from production to sandbox mode or manually by an organization administrator.

If this is the cause, you can disable administration mode by performing actions listed [here](../admin/manage-sandbox-instances.md#administration-mode). Once administration mode is disabled, portal will work fine.

### Authentication connection between Dynamics 365 for Customer Engagement organization and portal is broken

This issue occurs when the authentication connection between Dynamic 365 organization and portal is broken because either Dynamics 365 organization was restored from a backup or was deleted and recreated from a backup. To fix this issue:

1. Go to the Dynamics 365 Administration Center page and select the **Applications** tab.
2. Select the name of the portal that you want to reset, and then select **Manage**.
3. In the **Portal Details** tab, select **Off** from the **Portal State** list.
4. Select **Update**.
5. Select **On** from the **Portal State** list.
6. Select **Update**. The portal restarts and will be able to make authentication connection.

However, in certain situations especially if the organization ID has changed after the restore operation (or if you reprovisioned the organization), these mitigation steps will not work. In those situations, you can reset and reprovision the portal against the same instance. For information on how to reset a portal, see [Reset a portal](reset-portal.md).

### Request to Dynamics 365 organization has timed out

This issue is typically a transient issue which can occur if the API requests to your Dynamics 365 organization has timed out. This issue will automatically mitigate itself once the API requests starts working. To mitigate this issue, you can also try restarting the portal:

1. Go to the Dynamics 365 Administration Center page and select the **Applications** tab.
2. Select the name of the portal that you want to reset, and then select **Manage**.
3. Go to **Portal Actions** > **Restart**.

If restarting the portal doesn't work and this issue is occurring for a long period of time, please contact Microsoft support for help.

### Website binding not found

This issue occurs when the website binding records for portal are deleted from the underlying Dynamics 365 organization and portal is not able to create binding automatically. To fix this issue:

1. Sign in to Dynamics 365 for Customer Engagement.
2. Go to **Portals** > **Website Bindings**.
3. Delete all the website binding records which are pointing to your portal. The **Sitename** field helps you to identify website binding records of your portal.
4. After you delete all website binding records, restart the portal.

Once you complete the above steps, your portal will restart and will recreate website binding record automatically.

However, there are situations in which portal will not be able to recreate website binding record automatically when the GUID of the website record available in your Dynamics 365 instance is different than the one created during default installation of portal. In this situation, perform the following steps:

1. Delete all website binding records pertaining to your portal.
2. Create a website binding record manually with following values:
  - **Name**: Can be any string
  - **Website**: Select the website record which you want to be rendered on portal
  - **Sitename**: Type in the hostname of your portal i.e Portal URL without https:// in the beginning. If your Portal is using custom domain name, then use custom domain name here.
  - Leave all other fields blank.
3. Once website binding record is recreated, restart your portal from Portal Admin Center.

### An unexpected error has occurred while trying to connect to your Dynamics 365 organization

This situation can arise due to some unexpected issue. To mitigate in this situation, you can either try resetting or reprovisioning the portal. For information on how to reset a portal, see [Reset a portal](reset-portal.md).

If portal reset and reprovision doesn't solve this issue, please reach out to Microsoft support for help.

## Portal is not displaying updated data from Dynamics 365 organization

Any Dynamics 365 data displayed on portal is rendered from the portal cache. This cache gets updated whenever data in Dynamics 365 organization is updated. However, this process is asynchronous and can take upto 15 minutes. If the changes are made in the metadata entity of portal, for example, web pages, web files, content snippet, site setting, and so on, it is advised to clear cache manually or restart the portal from Portal Admin Center. For information on how to clear cache, see [Clear the server-side cache for a portal](clear-server-side-cache.md). 

However, if you are seeing stale data for a long time in non-portal metadata entities, it can be because of variety of issues listed below:

### Entities not enabled for cache invalidation

If you are seeing stale data only for certain entities and not for everything, this can be because the Change Tracking metadata is not enabled on that specific entity.

If you run the Portal checker (self-service diagnostic) tool, it will list down Object Type code of all the entities which are referenced on portal in entity list or entity forms and web forms and are not enabled for change tracking. Browse your metadata by using the steps mentioned at [Browse the metadata for your organization](../developer/browse-your-metadata.md)

If you are experiencing stale data issue in any of these entities, you can enable change tracking by using Dynamics 365 admin UI or Dynamics 365 API. More information:  [Enable change tracking for an entity](../developer/use-change-tracking-synchronize-data-external-systems.md#enable-change-tracking-for-an-entity)

### Organization not enabled for change tracking

Apart from each entity being enabled for change tracking, organizations on a whole has to be enabled for change tracking as well. An organization is enabled for change tracking when a portal provisioning request is submitted. However, this can break if an organization is restored from an old database or reset. To fix this issue:

1. Go to the Dynamics 365 Administration Center page and select the **Applications** tab.
2. Select the name of the portal that you want to reset, and then select **Manage**.
3. In the **Portal Details** tab, select **Off** from the **Portal State** list.
4. Select **Update**.
5. Select **On** from the **Portal State** list.
6. Select **Update**. The portal restarts and will be able to make authentication connection.

## Performance best practices

Performance issues in portals can be caused by a variety of configuration issues. All the out-of-the-box portal templates are tested for a variety of load conditions and configurations which can affect portal performance and below is the list of common portal configurations which can lead to performance issues in your portal.

Portal checker (self-service diagnostic) tool will also point out these issues by looking at your portal configuration.

### Web page tracking enabled

Enabling a portal web page for page tracking can lead to performance issues in your portal. This functionality is deprecated since January 2018 release of Dynamics 365 Portal. More information: [Portal capabilities for Dynamics 365: Deprecated Features](https://blogs.msdn.microsoft.com/crm/2018/03/20/portal-capabilities-for-dynamics-365-deprecated-features/)

The portal checker tool will list all the web pages (both root and content page) which are enabled for page tracking. These pages should be disabled by following these steps:

1. Sign in to Dynamics 365 for Customer Engagement.
2. Go to Advanced find.
3. Search for all the web pages where **Enable Tracking (Deprecated)** field is enabled (value is set to Yes).
4. Bulk edit all the pages and set this field to **No**.

Alternatively, you can also go to each page listed in portal checker result and set the value of **Enable Tracking (Deprecated)** field to **No**. It is important to understand that if you are on Portal solution version 9.x, this field will not be displayed on the form and you might need to add it to the form first. 

### Web file tracking enabled

Enabling a portal web file for page tracking can lead to performance issues in your portal. This functionality is deprecated since January 2018 release of Dynamics 365 Portal. More information: [Portal capabilities for Dynamics 365: Deprecated Features](https://blogs.msdn.microsoft.com/crm/2018/03/20/portal-capabilities-for-dynamics-365-deprecated-features/)

The portal checker tool will list all the web files which are enabled for page tracking. These files should be disabled by following these steps:

1. Sign in to Dynamics 365 for Customer Engagement.
2. Go to Advanced find.
3. Search for all the web files where **Enable Tracking (Deprecated)** field is enabled (value is set to Yes).
4. Bulk edit all the records and set this field to **No**.

Alternatively, you can also go to each file listed in portal checker result and set the value of **Enable Tracking (Deprecated)** field to **No**. It is important to understand that if you are on Portal solution version 9.x, this field will not be displayed on the form and you might need to add it to the form first. 

### Login tracking enabled

Enabling a portal login tracking can lead to performance issues in your portal. This functionality is deprecated since January 2018 release of Dynamics 365 Portal. More information: [Portal capabilities for Dynamics 365: Deprecated Features](https://blogs.msdn.microsoft.com/crm/2018/03/20/portal-capabilities-for-dynamics-365-deprecated-features/)

The portal checker tool will check if login tracking is enabled for your portal and will show a failed check if it is enabled. Login tracking should be disabled by following these steps:

1.	Sign in to Dynamics 365 for Customer Engagement.
2.	Go to **Portals** > **Site Settings**.
3.	Search for site setting named `Authentication/LoginTrackingEnabled`.
4.	Change the value of this site setting to **False** or delete the site setting.
5.	Restart the portal. 

### Header output cache is disabled

Disabling header output cache on your portal can lead to performance issues in your portal during high load. More details around this functionality can be found at: [Enable header and footer output caching on a portal](enable-header-footer-output-caching.md)

The portal checker tool will check if header output cache is disabled on your portal and will show a failed check if it is disabled. To enable it:

1.	Sign in to Dynamics 365 for Customer Engagement.
2.	Go to **Portals** > **Site Settings**.
3.	Search for site setting named `Header/OutputCache/Enabled`.
4.	If the site setting is available, change the value of Site setting to **True**. If the site setting is not available, create a new site setting with this name and set its value to **True**.
5.	Restart the portal. 

### Footer output cache is disabled

Disabling footer output cache on your portal can lead to performance issues in your portal during high load. More details around this functionality can be found at: [Enable header and footer output caching on a portal](enable-header-footer-output-caching.md)

The portal checker tool will check if footer output cache is disabled on your portal and will show a failed check if it is disabled. To enable it:

1.	Sign in to Dynamics 365 for Customer Engagement.
2.	Go to **Portals** > **Site Settings**.
3.	Search for site setting named `Footer/OutputCache/Enabled`.
4.	If the site setting is available, change the value of Site setting to **True**. If the site setting is not available, create a new site setting with this name and set its value to **True**.
5.	Restart the portal. 

### Large number of web file records

The web file entity is used by a portal to store any static files you want to use on your portal. Main use case of this entity is to store static content of your website like CSS, JavaScript, image files, and so on. However, having many such files can cause slowness during the startup of your portal.

The portal checker tool will check for this scenario and will provide you an indication if you have more than 500 active web files in your portal. If all of these files represent static content like CSS, JavaScript, image files, and so on, you can take following actions to mitigate this issue.

- Use an external file server like Azure blob storage or CDN to store these files and then reference these files on the appropriate pages either within the page or in underlying template.

- If you cannot move files outside, the ensure that all the files are not loaded along with home page. A web file is loaded along with home page if the parent page of that file is set to home. To avoid this scenario, you can perform the following steps:

  1. Create a dummy web page with no content and a blank template. This page would be used to create a direct path to your web files. 
  2. For all the web files which are not needed on home page, change the parent page to this dummy webpage. Once done, full path to your web file would be `Portal URL/{dummy_webpage}/{web file}`
  3. Reference your web file directly in the HTML of the page template or web template of the page where you want to use it. This will load your file on demand on that page. 

### Loading static resources (css/js) asynchronously

When working on portal implementation, it is important to understand that you completely manage the HTML of the page which means standard web development practices should be followed to ensure that your webpage's client side performance is not impacted. 

One of the most common cause of performance issues on webpages is loading a lot of static resources (css/js) synchronously on the load of the page. Synchronous loading of large no of css/js files can lead to long client-side processing time for your webpages. 

In case of Portals, whenever you are associating a web file directly to the home page, it creates a dependency in the generated HTML which means that web file always loaded along with the home page. If this web file is a css/js file, this would be loaded synchronously and can slow down your client-side processing time. 

To avoid this, you can perform the following steps: 

1. If a web file is not needed on the home page, make sure its parent page is not set as home page and reuse the mechanism described above to load it on demand.
2. While loading a JavaScript file on demand on any page, use `<async>` or `<defer>` HTML attribute to load the file asynchronously.
3. While loading a CSS file on demand, you can use `<preload>` HTML attribute (https://www.w3.org/TR/preload/) or JavaScript based approach since preload is not supported on all the browsers yet.

