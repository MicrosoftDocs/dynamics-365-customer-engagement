---
title: Enhanced case management in multisession apps
description: Learn about the enhanced case management in Customer Service multisession apps.
author: gandhamm 
ms.author: mgandham 
ms.reviewer: mgandham
ms.topic: conceptual
ms.date: 09/30/2024 
ms.custom: bap-template 
---


# Enhanced case management in multisession apps

The Customer Service workspace offers an enhanced case management experience. Agents can verify and edit customer details without switching tabs, and can update existing cases without interrupting the case creation flow. The enhanced experience also helps prevent case duplication.

## Create cases by using a quick create from

You can use a quick create form to create a new case from within a form without having to go to a different page.

For example, if you select **New Case** on the Customer Service Agent Dashboard, a quick create form for a new case appears as a flyout.

Depending on the settings that are enabled for you, the form that opens is either the enhanced quick case form or the default **Quick Create: Case** form.

   ### [Enhanced quick case form](#tab/enhancedquickcreateform)

   The enhanced quick case form opens when you select **New Case** in the following places:

   - Customer Service Agent Dashboard.
   - AI-generated summary of a customer conversation.
   - contact or account form 
   - Active conversation form
   - **Child cases** subgrid on an existing case.

 You can perform the following actions when the quick case form is open:

   - Access, copy, or edit the information in the background form or view. You can also paste information from the background to the case form.
   - On **New Case**, you can specify data in the following tabs:
      - **Details**: This tab includes the following fields:
           - Required fields for the case, such as **Customer** and **Title**.
           - A **Description** field, where you enter information that's related to the case. Use the rich text editor toolbar to format the text in this field and add images and links. You can also drag files into the description section.
           - Color-coded **Case Status** fields and **Priority**.
      - **Case notes**: You can add relevant information without having to save the case. Examples include the steps that you took to try to fix the issue or important details that must be included as notes. Use the rich text editor toolbar to format the text in this field and add images and links. You can add attachments either by using the attachment button to upload files or by dragging files.
      - **Attachments**: Select **Add Attachment** to upload multiple attachments at once.
   - If you’d like to provide additional information, you can switch to the main case form.  All the details you've added to the case are added automatically when you switch to the main form.
    
   :::image type="content" source="../media/quick-case-contact-mini.png" alt-text="Enhanced quick case form" lightbox="../media/quick-case-contact.png":::

   ### [Default Quick create form: case](#tab/quickcreateform)
    
   The default **Quick Create: Case** form appears when you create a case using the quick create option.

   :::image type="content" source="../media/quick-case-default-mini.png" alt-text="Screenshot of the Default Quick Create: Case form." lightbox="../media/quick-case-default.png":::

   ---

## Create a case from the main case form

You can create a new case from the main case form. The layout depends on whether your administrator has enabled the enhanced full case form in Customer Service admin center.

Depending on the settings that are enabled for you, either the enhanced full case form or the default main case form opens.

   ### [Enhanced full case form](#tab/enhancedfullcaseform)

   You can perform the following actions in the enhanced full case form:
   - Specify the customer to display the relevant customer details and recent cases on **Customer Card** and  **Recent cases**.
   - Use **Case Notes** and **Description** to record notes and information related to the case. Use the rich text editor toolbar to format the text in the fields and add images and links. You can also drag files into the description section.
   - In **Attachments**, select **Add Attachment** to upload multiple attachments at once.
   -  View color coded **Case Status** fields and **Priority** icons.
   - Select **Save and Resolve** at the top of the form to save the case and initiate the case resolution process.
    
     :::image type="content" source="../media/enh-case-newcase-mini.png" alt-text="Screenshot of the enhanced full case form." lightbox="../media/enh-case-newcase.png":::

   ### [Default main case form: Case](#tab/fullcaseform)
    
   On the **Case for Multisession experience** form, which is the default case form for Customer Service workspace, you can do the following: 

   - See color coded **Case Status** fields and **Priority** icons.
   - See the **Attachment** tab. The attachment tab displays the attachments that are linked to the case. You can upload attachments from this tab only if your administrator has configured the attachment control.
   - **Activities Due** section. When the case is saved, the section displays links to the activities that are associated with the case, and are due or overdue on the current date. Select a link to view the activities in the **Due Activities** view.
   - **Queue item details**. Once you save the case and route the case to a queue, this field displays the current queue the case belongs to and the **Worked by** field

   :::image type="content" source="../media/case-multisession-app-mini.png" alt-text="Screenshot of the multisession app" lightbox="../media/case-multisession-app.png":::

 ---

## View an existing case by using the enhanced full case form

If you save the case by using the enhanced full case form, the application displays the following elements:
   - A service level agreement (SLA) timer that displays the time within which the agents must first respond to a customer and the time by which they must resolve the case.
   - Links to the activities that are associated with the case, and that are either due on the current date or past their due date. Select a link to view the open activities associated with the case on a tab that your administrator has configured. By default, the application displays open activities on the **Activities** tab. [Learn how to specify a tab to redirect users to view the open activities for a case.](../administer/case-enh-config.md)
   - A **Customer Details** side pane that displays related customer information and recent case information.
   - **Queue item details**, which displays the current queue the case belongs to and the **Worked by** field.
   - **Case associations**, which displays details of the relevant records that are associated with a case. 
   - A timeline that displays information related to the events that happened on the case.
   - An **Attachment** tab, where you can upload and view attachments that are linked to the case. You can also perform the following actions:
      - View the source of the attachments, such as direct uploads or attachments that were uploaded through notes or email, or shared through conversation, and the user who uploaded the attachments.
      - Use the dropdown list to switch between grid and tile views.
      - Search for attachments.
      - Sort and filter attachments based on **Name**, **Size**, **Uploaded on**, **Uploaded by**, and **Source**.
      - Select an attachment to preview the content of the attachment. This functionality is supported only for PDF and image files.
      - Download and delete multiple attachments at once.

   > [!NOTE]
   > - You can delete only those attachments that have **Source** set to **Direct Upload**.
   > - Attachments shared over a conversation are displayed only if a case is linked to the conversation and the conversation has ended. The **Uploaded By** is set to **Omnichannel User** and **Uploaded on** is the time when the conversation ended.
   > - The enhanced full case form opens when you open an existing case only if your administrator has set the enhanced full case form as the default form.

:::image type="content" source="../media/edit-enh-fullcase.png" alt-text="Screenshot that shows the enhanced main case form for a saved case." lightbox="../media/edit-enh-fullcase.png":::


## View customer details and recent cases

When you create a new case and specify a customer or an account, or open a case after you save it, the application displays the following details, based on your administrator's configurations:

- **Customer Details**: Displays the customer details configured by your administrator. You can edit the information inline, copy the information and initiate activities such as email or a phone call. The activities open as a new quick create form on the main page.
- **Recent Cases**: Displays the recent cases that are linked to the customer or account. More information: [Configure components to display customer details and recent records](../administer/add-display-components-to-case-form.md).


### Related information

[Enable enhanced case forms for multisession apps](../administer/case-enh-config.md)<br>
[Get started with Customer Service workspace](../implement/csw-overview.md)<br>
[View Active conversation to get available information about customers](../use/oc-customer-summary.md)
