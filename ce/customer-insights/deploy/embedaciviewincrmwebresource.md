---
title: Embed a Customer Insights widget in a Dynamics 365 web resource | Microsoft Docs
description: This section takes you through the steps for embedding Customer Insights widgets in the Customer Insights application that targets a specific role or audience.
keywords: dynamics 365; customer insights
Applies_to: Dynamics 365 for Customer Insights
author: jimholtz
ms.author: jimholtz
manager: brycho
ms.date: 07/03/2017
ms.topic: get-started-article
ms.service: customer-insights 
ms.assetid: 8418d9c3-ff83-49f6-b8b9-c57c1f64b985
---
Embed a [!include[](../../includes/pn-customer-insights-short.md)] widget in a [!include[](../../includes/pn-dynamics-crm.md)] web resource
=========================
[!include[pre release disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

Follow these steps to add a [!include[pn-customer-insights](../../includes/pn-customer-insights-full.md)] widget to your [!include[pn-crm-shortest](../../includes/pn-crm-shortest.md)] web resource. 

##Prerequisites

This section takes you through the steps for embedding [!include[pn-customer-insights](../../includes/pn-customer-insights-short.md)] widgets in the [!include[pn-customer-insights](../../includes/pn-customer-insights-short.md)] application that targets a specific role or audience.

>-   The [!include[pn-crm-shortest](../../includes/pn-crm-shortest.md)] users who need to view the [!include[pn-customer-insights](../../includes/pn-customer-insights-short.md)] widgets in [!include[pn-crm-shortest](../../includes/pn-crm-shortest.md)] must be granted read permissions to the appropriate profiles, interactions, and interactions that the widgets show, in addition to the widgets and views that are being embedded. [!include[proc-more-information](../../includes/proc-more-information.md)] [Step-by-step role-based security](./stepbysteprolebasedsecurity.md).

>-   The [!include[pn-crm-shortest](../../includes/pn-crm-shortest.md)] organization admin user needs admin privileges for the [!include[pn-customer-insights](../../includes/pn-customer-insights-short.md)] hub as well. To do this, go to the [!include[](../../includes/pn-azure-portal.md)] > **your [!include[pn-customer-insights](../../includes/pn-customer-insights-short.md)] hub** > **Settings** > **Security** > **Add**.

>-   Do not select **Restrict cross site scripting** in a [!include[pn-crm-shortest](../../includes/pn-crm-shortest.md)] entity or web resource customization if it is going to be a container for the [!include[pn-customer-insights](../../includes/pn-customer-insights-short.md)] view.

##Steps

1.  Define views by using available profile types in [!include[pn-customer-insights](../../includes/pn-customer-insights-short.md)], which can represent Account, Lead, Opportunity, or Contact entities in [!include[pn-crm-shortest](../../includes/pn-crm-shortest.md)].

2.  Create a simple HTML file to add as web resource or other custom entity in [!include[pn-crm-shortest](../../includes/pn-crm-shortest.md)].

3.  Customize entities in [!include[pn-crm-shortest](../../includes/pn-crm-shortest.md)] to use the web resource created in step 2.

4.  Check the embedded view in [!include[pn-crm-shortest](../../includes/pn-crm-shortest.md)].

5.  Troubleshoot.

##Details

1.   Define [!include[pn-customer-insights](../../includes/pn-customer-insights-short.md)] views and extract the URLs of the embedded views. [!include[more information](../../includes/proc-more-information.md)] [Embedding a Customer Insights view](./embedaciview.md).

2.   Create a [!include[pn-crm-shortest](../../includes/pn-crm-shortest.md)] web resource.

     This will be a typical [!include[pn-crm-shortest](../../includes/pn-crm-shortest.md)] web resource. In this example, we are creating an HTML file that contains:

     >-   Iframe to show the [!include[pn-customer-insights](../../includes/pn-customer-insights-short.md)] view.

     >-   Javascript function - called in HTML body onload to build iframe 'src' attribute value at runtime.

     <!--See the "sample webresource.txt" sample HTML file.-->

     After it is created, the same web resource can be added and published in [!include[pn-crm-shortest](../../includes/pn-crm-shortest.md)] by using **Settings** > **Customizations** > **Customize the system** > **Web resources** > **New**. 

3.   Customize [!include[pn-crm-shortest](../../includes/pn-crm-shortest.md)] entities.

     In this step, we will insert the web resource created above into views for [!include[pn-crm-shortest](../../includes/pn-crm-shortest.md)] entities such as Account, Lead, Opportunity, and Contact.

     1.  Choose any entity that you want to show [!include[pn-customer-insights](../../includes/pn-customer-insights-short.md)] views and widgets.

     2.  Choose one of the active forms where you want to see the [!include[pn-customer-insights](../../includes/pn-customer-insights-short.md)] view or widget.

     3.  Search for the web resource you published above, and insert it into the form in an existing section or a new section.

     4.  When you insert the web resource, make sure the field you select as a dependency corresponds to the *filterValue* used in the web resource HTML. For example, if the [!include[pn-customer-insights](../../includes/pn-customer-insights-short.md)] URL query parameter has the format *filterkey=Email&filtervalue=some@abc.com*, add the *Email* field from the [!include[pn-crm-shortest](../../includes/pn-crm-shortest.md)] entity in the dependency for the web resource.
     
      Sample web resource:

       ```html
       <!doctype html>
       <html lang="en">
       <head>
           <meta http-equiv="Content-Type" content="text/html; charset=utf-8">
           <title>
               Customer Insights View
           </title>
           <script type="text/javascript">
               function onLoad() {
                   var dciFrame = document.getElementById("frameDCIView");
                   if (dciFrame) {
                       dciFrame.src = formIframeUrl();
                   }
               }

               function formIframeUrl() {      
                   //Typical DCI url format goes like 'https://<DCI hub name>.apps.azurecustomerinsights.com?viewid=<DCI view id>'
                   var dciViewUrl = "https://<DCI-hub-name>.apps.azurecustomerinsights.com?viewid=<DCI-view-id>";
                   //Fetching entity name from CRM page in the context
                   var crmEntityName = window.parent.Xrm.Page.data.entity.getEntityName()+ "id";
                   //Fetching entity id from CRM page in the context
                   var crmEntityId = window.parent.Xrm.Page.data.entity.getId();
                   if(!!crmEntityId){
                       if(crmEntityId.indexOf("{") >= 0){
                           // Clipping off {} from guid Eg. {D3AE1B3A-8BD2-E411-80EF-C4346BAC7BE8} to D3AE1B3A-8BD2-E411-80EF-C4346BAC7BE8                 
                           crmEntityId = crmEntityId.substring(1,crmEntityId.length - 1);
                       }
                       var filter = "&filterkey=" + crmEntityName + "&filtervalue=" + crmEntityId.toLowerCase();
                       // Final url format would be 'https://<DCI hub name>.apps.azurecustomerinsights.com?viewid=<DCI view id>&filterkey=<crmEntityName>&filtervalue=<crmEntityId>'
                       return dciViewUrl + filter; 
                   }else{
                       console.error("Unable to render Customer Insights View");
                   }  
                   return "";
               }
           </script>
       </head>
       <body onload="onLoad()">
           <iframe id="frameDCIView" src=''></iframe>
       </body>
       </html>
       ```

     5.  Save and publish the entity.

4.   Check the embedded view.

     1.  Open one of the customized entities from [!include[pn-crm-shortest](../../includes/pn-crm-shortest.md)].

     2.  The [!include[pn-customer-insights](../../includes/pn-customer-insights-short.md)] view should be visible in the web resource added for the entity in context.

5.   Troubleshoot.

     **If only the [!include[pn-customer-insights](../../includes/pn-customer-insights-short.md)] nav bar [header] is showing**:

     >-   This may be due to an [!include[](../../includes/pn-azure-active-directory.md)] token conflict during single sign-on. Make sure the [!include[pn-crm-shortest](../../includes/pn-crm-shortest.md)] signed-in user is part of [!include[](../../includes/pn-azure-active-directory.md)] for the [!include[pn-customer-insights](../../includes/pn-customer-insights-short.md)] hub.

