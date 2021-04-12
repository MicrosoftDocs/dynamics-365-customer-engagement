---
title: "Customize Dynamics 365 for phones and tablets (Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
ms.custom: 
ms.date: 06/18/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
author: mattp123
ms.assetid: a3e6a322-18f7-48bd-aaea-bff7675d1378
caps.latest.revision: 35
ms.author: matp
manager: kvivek
search.audienceType: 
  - customizer

---
# Customize Dynamics 365 for phones and tablets to work for your business



With Dynamics 365 Customer Engagement (on-premises), you can design once and deploy everywhere. Customizations you make to your [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] system appear in the Dynamics 365 for phones and tablets apps as well as in the web app. Your changes are optimized in the mobile apps so they display properly. Choose one of the following or scroll down to see the types of changes you can make, and how they might display differently in the mobile apps than the web app.  

 The latest version of the phone app, [!INCLUDE[pn_Mobile_Express_long](../includes/pn-mobile-express-long.md)], provides the same full-featured experience as the [!INCLUDE[pn-dyn-365-tablets](../includes/pn-dyn-365-tablets.md)] app. It has the same intuitive user interface (adapted for phones), as well as offline capabilities. 

 After you’ve made customizations to a form, users will see a prompt to download updates the next time they open their mobile app.  

 [Watch a short video (1:51) about customizing the Dynamics 365 Customer Engagement (on-premises) mobile app](https://go.microsoft.com/fwlink/p/?linkid=836829).  


## Home page for Dynamics 365 for phones and tablets  
 When users first open [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] for phones and tablets, they’ll see the home page, which defaults to the **Sales Dashboard**. You can create new dashboards or edit existing ones in the web app and enable them for mobile, and users can choose a different Home dashboard. For more information about creating or changing dashboards, see [Create a dashboard](../customize/create-edit-dashboards.md) or [Manage dashboard components](../customize/manage-dashboard-components.md).  

<a name="BKMK_FormCustomizations"></a>   
## Form customizations for Dynamics 365 for phones and tablets  
 [!INCLUDE[pn_Mobile_Express_short](../includes/pn-mobile-express-short.md)] and [!INCLUDE[pn_moca_short](../includes/pn-moca-short.md)] use the forms as the web app. The way the form displays in the app is optimized for the mobile experience.  The following diagrams show the reflow from the web app to the tablet and phone apps:  

 **Web app**  

 ![Dynamics 365 for Customer Engagement form reflow from web app](../customize/media/custon-reflow-web-app.png "Dynamics 365 Customer Engagement (on-premises) form reflow from web app")  

 **Tablet app**  

 ![Dynamics 365 for Customer Engagement form reflow to tablet app](../customize/media/reflow-tablet-app.png "Dynamics 365 Customer Engagement (on-premises) form reflow to tablet app")  

 **Phone app**  

 ![Dynamics 365 for Customer Engagement form reflow to phone app](../customize/media/custon-reflow-phone-app.png "Dynamics 365 Customer Engagement (on-premises) form reflow to phone app")  

 Dynamics 365 for phones and tablets does not provide the capability to switch between forms. If you have more than one main form for an entity, the one displayed depends on the form order set and which security roles are assigned to the form. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Multiple forms](../customize/main-form-presentations.md#BKMK_MultipleForms)  

 While customizing a form, you can hide the following from the [!INCLUDE[pn_Mobile_Express_short](../includes/pn-mobile-express-short.md)] experience:  

1.  Fields  

2.  Sections  

3.  Entire tabs  

That way, if you think phone users need to focus only on the primary information for a contact, for example, you can hide the contact details from the phone app while you’re customizing the form.  

### Hide details from the Dynamics 365 for phones display  

1.  While customizing a form in the form editor, select the field, section, or tab you want to hide. For tips on using the form editor, see [Use the form editor](../customize/create-design-forms.md).  

2.  Click **Change Properties**.  

3.  Clear **Available on phone** and click **OK**.  


<a name="BKMK_NavigationOptions"></a>   
## Change navigation options for Dynamics 365 for phones and tablets  
 Dynamics 365 for phones and tablets uses the same sitemap data to provide navigation options as the web application except that it is optimized for presentation in the mobile apps.  

 If an entity that appears in the navigation bar for the web application is enabled for Dynamics 365 for phones and tablets, it will also appear on the navigation bar in the mobile apps.  

 A grouping within an Area on the web client is ignored in the mobile apps, which show entities as a flat list. You can add an entity to multiple groups on the web client. The mobile apps will display a flattened list and will not show any repeats. Users won’t see an entity unless they have read access to that entity.  

 The order of the items in the nav bar is determined by the order in the site map. If there is a duplicate, only the first instance will show.  

 Custom entities use a fixed custom entity icon.  

 ![Dynamics 365 for tablets nav bar](../customize/media/dynamics-365-tablets-navigation-menu.png "Dynamics 365 for Tablets nav bar")  

See [Change application navigation using the SiteMap](../developer/customize-dev/change-application-navigation-using-sitemap.md) for more information. 

<a name="BKMK_ChangeCommands"></a>   
## Change commands for Dynamics 365 for phones and tablets  
 Dynamics 365 for phones and tablets uses the same ribbon definitions to provide commands as the web application except that it is optimized for presentation in the mobile apps. You can set the ribbon definitions to display based on the type of client. For example, you can set commands so they appear in the web app but not the phone or tablet apps. Some default commands are set to appear only in the web app, which is why you won’t see them in the mobile apps.  

 ![Account form commands for Dynamics 365 for tablets](../customize/media/mobile-app-account-form-command.PNG "Account form commands for Dynamics 365 for tablets")  

> [!NOTE]
>  Icons configured for commands aren’t displayed, and labels that are too long are truncated.  

 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Customize commands and the ribbon](/previous-versions/dynamicscrm-2016/developers-guide/gg309639(v=crm.8))  

<a name="BKMK_FormScriptDifferences"></a>   
## Form script differences for Dynamics 365 for phones and tablets  
 Scripts written for forms used in the web application should also work with Dynamics 365 for phones and tablets, but there are some differences. As a rule, methods that aren’t valid within for the mobile apps don’t return errors, but they also don’t return any values. <!-- Developers can use a conditional statement to separate code that won’t work correctly in the mobile apps.  -->

 The following list shows what to expect with scripts in the mobile apps. For specific details, see the developer documentation in the [Client API Reference for Customer Engagement](/dynamics365/customer-engagement/developer/clientapi/reference).  

- Using [window.alert](https://msdn.microsoft.com/library/ie/ms535933.aspx), [window.confirm](https://msdn.microsoft.com/library/ie/ms536376.aspx), [window.prompt](/previous-versions/windows/internet-explorer/ie-developer/platform-apis/ms536673(v=vs.85)) or any other code that blocks code execution while waiting for a user’s response won’t work as expected or will display an error. You shouldn’t use these methods in scripts for the mobile apps.  

- Because tabs displayed in Dynamics 365 for phones and tablets can’t expand or collapse, code that tries to expand or collapse them won’t work, and code configured for event handlers using these events won’t execute.  

- Web resource or iFrame elements in your dashboards won’t display in the mobile apps. Methods that interact with them won’t work, and code configured for event handlers using these for the events called when these items load won’t run. If you’re interested in trying out a preview feature that does display web resource or iFrame elements in [!INCLUDE[pn_moca_short](../includes/pn-moca-short.md)], see [iFrame and web resource support in CRM for tablets](iframe-web-resource-support-dynamics-365-phones-tablets.md).  

- Because Dynamics 365 for phones and tablets doesn’t provide the ability for a user to switch to different forms, methods that enable this in the web application won’t work.  

- Any methods for showing or navigating to related entities in the web application won’t work.  

- Methods that would refresh the command bar, get dimensions of the view port, or close a form window won’t work.  

<a name="BKMK_PublishingCustomizations"></a>   
## Publishing customizations for Dynamics 365 for phones and tablets  
 When you customize Dynamics 365 for phones and tablets, you should always explicitly publish your customizations to make sure they synchronize with the mobile apps.  

<a name="BKMK_BusinessRulesCached"></a>   
## Business rules in Dynamics 365 for phones and tablets  
 Business rule definitions are downloaded and cached when Dynamics 365 for phones and tablets opens. Changes made to business rules aren’t applied until the user closes and re-opens the mobile app.  



### See also  
 [Video: Visual controls (4:32)](https://go.microsoft.com/fwlink/p/?LinkID=724424) <br/>
 [Create and edit metadata](../customize/create-edit-metadata.md)   
 [Create and design forms](../customize/create-design-forms.md)   
 [Create or edit views](../customize/create-edit-views.md)   
 [Create or edit processes](../customize/create-business-process-flow.md) <br/>
 [Create business rules and recommendations](../customize/create-business-rules-recommendations-apply-logic-form.md)



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
