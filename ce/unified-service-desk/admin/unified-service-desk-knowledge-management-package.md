---
title: "Unified Service Desk  – Knowledge Management package | MicrosoftDocs"
description: "Overview of the Knowledge Management sample application."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/23/2017
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-USD
  - dyn365-admin
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - D365USD
---
# Knowledge Management sample application package 

[!INCLUDE[cc-data-platform-banner](../../includes/cc-data-platform-banner.md)]

[!INCLUDE[pn_unified_service_desk_for_crm](../../includes/pn-unified-service-desk-for-crm.md)] provides a configurable framework for quickly building applications for call centers so the customer service reps get a unified view of the customer data stored in Microsoft Dataverse or any other application.  
  
 If you’re a service rep, you can use [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] to offer your customers a reliable and consistent experience across a number of different channels including phone, email, and chat, and can also serve multiple customers simultaneously through sessions. A system administrator in your organization can integrate Unified Service Desk with many other applications that you use on a day-to-day basis so you can get your work done from your desktop without switching to different applications.  
  
 The [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] Knowledge Management sample application package provides a configuration for integrating Dataverse with the [!INCLUDE[pn_parature](../../includes/pn-parature.md)] knowledge base that lets you easily search for articles from your desktop and share them with customers right away, reducing call handling times and improving customer satisfaction.  
  
> [!IMPORTANT]
>  The sample applications are not supported for production use.  
> 
>  This sample application is useful only if you have set up knowledge management for Dataverse. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Set up knowledge management with a knowledge base](https://technet.microsoft.com/library/dn946909.aspx)  
  
 With the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] Knowledge Management package, the following components are installed:  
  
- User Interface Integration Solution  
  
- [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] Solution  
  
- Data required for Dataverse and customizations  
  
- Configurations for integrating [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] with knowledge management  
   
  
 Here’s what you’ll see when you install [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]:  
  
1. **Dashboards**: Opens the customer service dashboard.  
  
2. **My Work**: Shows a list of all the active cases assigned to a service rep.  
  
3. **search**: Opens search for navigating through various entities. For this package you can search for accounts contacts, cases, activities, and queues.  
  
4. **Session tabs**: Each tab shows a different session when you have multiple customer sessions open. The tabs make it easy for  reps to work on multiple customer cases.  
  
5. **Left pane**: When you open any session, the left pane area automatically opens and shows the call script for the session. You can open or collapse this pane.  
  
6. **Right pane**: When you open any session, the right pane automatically opens and lets you search for knowledge base articles.  
  
7. **Call Script**: Shows call scripts that the service rep can use when they’re working on a case. The scripts help guide the rep by giving them step-by-step instructions on how to handle the case.  
  
8. **Notes**: Shows an area to take notes in regarding the case.  
  
9. **Session timer**: Shows how long a service rep has been on the session.  
  
   ![Account session in Unified Service Desk](../../unified-service-desk/media/account-session-unified-service-desk.png "Account session in Unified Service Desk")  
  
## View your cases  
  
-   From the toolbar, click **My Work** to see all of your cases.  
  
## Create a case  
 Look up the contact information.  
  
1.  From the toolbar, click **search**.  
  
     An application tab opens with a list of records.  
  
2.  In the **search for records** box, enter the account or contact information.  
  
3.  When you find the information, click the record to open a new session.  
  
4.  In the left nav **Call Script** area, use the list of call scripts to guide you through the support case.  
  
     When you open a call script, a green check mark displays to indicate that the action has been performed.  
  
5.  Enter your case notes in the **Notes** area. To attach your notes to the case, click **Update notes** from call scripts.  
  
## Search for solutions  
 To help you resolve a case, use knowledge base articles to find a solution.  
  
1.  From the **Call script** area, click **search for a solution**.  
  
     The **KB Records** pane shows search results based on the title of the case. By default, the pane is configured to open in the right panel, but you can talk to your administrator to open this pane in the left or main panel.  
  
2.  To do a different search, use the **search** box to type a keyword and search for other articles.  
  
3.  In the search results, select the article by choosing the article blurb, and do one of the following:  
  
    -   To copy the URL of the article, click the **Copy Link** button ![Copy knowledge article link button](../../unified-service-desk/media/copy-link-button.png "Copy knowledge article link button"). You can then paste it in the chat session with customers or in the email body.  
  
        > [!NOTE]
        >  If you don’t see a URL when you try to paste it, it could be because the article is still in the draft state or is expired.  
  
    -   To send the link of the article to a customer, click the **Send Email**  button ![Case origin button for email](../../unified-service-desk/media/case-origin-email-button.png "Case origin button for email").  
  
         An email template opens with data populated in it.  
  
    -   To link the article with the case, click the **Link Article** button ![Link knowledge article to current case button](../../unified-service-desk/media/link-article-current-record.png "Link knowledge article to current case button").  
  
         Linking articles to cases helps in determining what articles were effective in resolving cases. You can also dissociate the article from the case by clicking the **Remove Link** button ![Unlink knowledge article from current record button](../../unified-service-desk/media/unlink-article.png "Unlink knowledge article from current record button").  
  
    -   To open the article in a new tab in the main panel and read its content, click the title of the article.  
  
         All actions like **Copy Link** or **Send Email** are available on this new tab.  
  
    -   Additionally, to open the article in a new browser window, click the **Pop Out** button ![Pop out knowledge article in a new window button](../../unified-service-desk/media/pop-out-article.png "Pop out knowledge article in a new window button"). This button is available only in the main panel and is particularly useful when you’re using multiple monitors. You can pop out an article and view it on a second monitor so that you can continue to use the first monitor to work on the case or take notes. While going through the article, you can click a link to go to a different page, and use the **Back** button ![Back button in Unified Service Desk](../../unified-service-desk/media/back-arrow-button.png "Back button in Unified Service Desk") to go back to the original article.  
  
    > [!TIP]
    >  Your system administrator can also set up the search control to search automatically based on certain criteria as soon as you open a session. To know more about this, talk to your system administrator.  
  
## Send an email  
  
-   From the list of call scripts, select the **Send email** call script, and then select a template that automatically populates the body of the email.  
  
## Update the notes  
  
- Enter your case notes in the **Notes** area.  
  
- From the list of call scripts, select the **Update the notes** call script. This will attach the notes you’ve taken during your conversation with the customer to the **Notes** tab of the case record in Dataverse.  
  
## Close the session  
 From the list of call scripts, select the **Close the session** call script. This will close the open session and collapse the left panel that shows the call script and right panel that lets you search KB articles.  
  
## See also  
 [Unified Service Desk Overview](../../unified-service-desk/admin/overview-unified-service-desk.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]