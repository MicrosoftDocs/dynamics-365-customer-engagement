---
title: Configure email
description: Learn how to configure email in customer engagement apps.
ms.date: 06/04/2024
ms.topic: article
author: lalexms
ms.author: laalexan
ms.reviewer: laalexan
---

# Configure email

[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]

Email is typically used as a communication channel between customers and agents throughout the lifecycle of support delivery. Regardless of the channel where a customer begins a conversation, agents often use email to send their customers confirmations, case IDs, attachments, or other communications of record throughout the support lifecycle.

In customer engagement apps, system administrators can configure email templates and enable quick access to email to help users create emails directly from the timeline so they can deliver a more personalized service.	

The following email configuration options are available:	
- [Configure the email form order](#configure-the-email-form-order): Allow users to access email capabilities and create an option on the command bar.
- [Enable the enhanced email experience](#enable-the-enhanced-email-experience): Allow users to use broader email functionality, such as expand the email editor pop-up window, apply predefined templates, and insert attachments to email.
- [Configure email attachments size limitations](#configure-email-attachment-size-limitations): Allows you to manage file size limits for email attachments.
- [Configure the attachment tiles thumbnail layout](#configure-attachment-tiles-thumbnail-layout): Allows you to configure the visual layout of attachments and the number of attachments to show per page.
- [Change the number of attachments to show per page](#change-the-number-of-attachments-to-show-per-page): Configure how many attachments you want to show.
- [Manage blocked attachment file types](#manage-blocked-attachment-file-types): Allows you to configure the types of file types you want to block users from being able to upload as email attachments.

## Configure the email form order

Email must be enabled for users so they can view and access it. When email is enabled, it shows as an option on the command bar.	

To enable email:

1. In Power Apps, go to **Settings** > **Advanced Settings**.
1. From the top menu, select **Settings** > **Customizations**.
1. Select **Customize the System**.
1. Expand **Entities**, select and expand **Email**, and then select **Forms**.
1. On the command bar, select **Form Order**, and then select **Main Form Set** from the drop-down list.
1. The **Form Order** window appears, which displays the enabled email forms that are available. If **Enhanced email** doesn't display at the top of the list, use the arrows to move it up so it displays first on the list, and then select **OK**.

   > [!Note] 
   > Both the Navigate-to and Contextual (pop-up) email experience use the same **Form Order**.

1.	When you complete your updates, select **Publish All Customizations** in the top-left corner to display the changes.


## Enable the enhanced email experience	

Enhanced email is the default setting, but you must enable email for users to access and use the features. 

1. Sign in to https://`<YourOrgURL>`.dynamics.com/apps and open a customer engagement app.

1. In the app, go to **Settings** > **Advanced Settings**.

2. Select **Settings** > **Administration**.

3. Select **System Settings**. The **System Settings** window is displayed.
 
4. Select the **Email** tab, scroll down to the **Enhanced email for Timeline** section, and then select the check box.  

5.	Select **OK** to save your global organizational setting and close the window.	

## Configure email attachment size limitations

You can manage file size limits for email file attachments by completing the following steps: 

1. In Power Apps, select **System Settings**.

2. In the **System Settings** display window that appears, go to the **Email** tab.

3. Scroll down to the  **Set file size limit for attachments** section, set the file size you want to use for attachment, and then select **OK**.

  > [!Note] 	
  > The default file size limit for attachments is 5 MB. The size limit for attachments can be increased to a maximum of 132 MB per file.

## Configure email pop-up window

When an agent selects **New Email** from the Timeline, you can choose to display the email editor either as a pop-up window or in a new tab. If you enable the email pop-up editor setting, agents see the following experience:

   :::image type="content" source="../media/email-popup-mini.png" alt-text="Enhanced quick case form" lightbox="../media/email-popup.png":::

Perform the following steps to display the email editor as a pop-up window:

1. Select  **Settings** > **Advanced Settings**.
2. Select **System** > **Administration**. 
3. Select **System Settings**. 
2. In the **System Settings** display window that appears, go to the **Email** tab.
3. Select **Multitask, compose, and save drafts using email pop-up windows when creating email from timeline** in the  **Enhanced email for Timeline** section, and then select **Ok**.

## Configure attachment tiles thumbnail layout

You can configure the attachment tiles thumbnail layout in email by selecting the Email entity form for enhanced email from the Advanced settings menu.

1. In Power Apps, go to **Advanced settings**.

2. Select **Customizations** > **Customize the System**.

3. Select **Entities** > **Email** > **Forms** > **Enhanced Email**.

4. Double-click the **Attachment** area of the form to show the **Properties** dialog.

5. If the **Read Only Grid** control isn't already present, add it by selecting the **Controls** tab and then selecting **Add Control**.

6. After you add the **Read Only Grid**, you can select it to set the properties you want. Choose from the following:
  - **Reflow Behavior**: Determines whether the layout of a grid changes to a list layout when not enough space is available.
    - **Reflow**: Shown in list mode or grid mode, depending on the available size.
    - **List Only**: Shown in list mode only.
    - **Grid Only**: Shown in grid mode only.
  - **Attachment List Style**: The way individual attachments are displayed in list mode (for the Attachment entity only)
    - **Grid**: Shown in block with multiple attachments per row.
    - **Rows**: Default experience with a single attachment per row.

For example, we set **Reflow behavior** to **List Only** and **Attachment list style** to **Rows**.

   ![Set Reflow behavior and Attachment list style.](../media/list-attachment-style.png "Set Reflow behavior and Attachment list style.")

These settings display attachments as follows:

   ![Attachments display.](../media/list-attach-list-display.png "Attachments display.")

Changing to **List** and **Grid** shows the following attachment layout:

   ![List and Grid layout.](../media/list-grid-layout.png "List and Grid layout.")

## Change the number of attachments to show per page

You can configure the maximum number of attachments to show per page. Adjust the settings on the **Formatting** tab of the **List or Chart properties** dialog. For example, if you set the **Number of Rows** property to 4, and then have more than four attachments per email, the rest of the attachments paginate and you can then use the arrow buttons to view them.  

## Manage blocked attachment file types

You can configure the attachment file types you want to block to prevent users from uploading certain files. 

1. In Power Apps, go to **Advanced settings**.

2. Select **System** > **Administration** > **System Settings**.

3. On the **General** tab, scroll down to **Set blocked file extensions for attachments**.

4. Type one or more file extensions you want to block. Users who try to upload a blocked file type see an error message that tells them the attachment is blocked.

### Related information

[Use email](../customer-service-hub-user-guide-email-overview.md)<br>
[Create an email template](../customer-service-hub-user-guide-email-create-template.md)<br>
[Insert an email template](../customer-service-hub-user-guide-email-insert-template.md)<br>
[Convert an email to a template](../customer-service-hub-user-guide-email-convert-template.md)<br>
[Use a signature in email](../customer-service-hub-user-guide-email-create-signature.md)<br>
[Email FAQ](../email-faqs.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
