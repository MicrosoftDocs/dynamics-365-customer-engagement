---
title: "Configure email | Microsoft Docs"
description: "Learn how to configure email in customer engagement apps."
author: lalexms
ms.author: laalexan
manager: shujoshi
ms.date: 04/05/2021
ms.topic: article
ms.service: "dynamics-365-customerservice"
ms.reviewer: lalexms
---

# Configure email

Email is a critical communication tool for agents to connect with customers during the support delivery lifecycle. Regardless of the channel where the customer begins a conversation, agents often use email to send confirmations, case IDs, attachments, or other communications of record throughout the support lifecycle. Email is almost always used as a communication channel between customers and agents throughout the lifecycle of support delivery.  

In customer engagement apps, system administrators have the ability to configure email templates and enable quick access to email to help users create emails directly from the timeline so they can deliver a more personalized service.	

How to navigate email configurations	
- [Configure the email form order](customer-service-hub-user-guide-email-admin.md#configure-the-email-form-order)	
- [Enable the enhanced email experience](customer-service-hub-user-guide-email-admin.md#enable-the-enhanced-email-experience)	
- [Configure email attachments size limitations](customer-service-hub-user-guide-email-admin.md#configure-email-attachment-size-limitations)	


## Configure the email form order	
Email must be enabled for users so they can view and access it. Unless email is enabled, it won't be available as an option on the command bar.	

To enable email:

1. Under **Settings** select **Advanced Settings**

    ![Navigate to advanced settings](media\email-how-to-enable-email-1z.png "Navigate to advanced settings.")	

2. In the top nav, select the **Settings** carat (v),  then select **Customizations** 

    ![Navigate to Customizations](media\email-how-to-enable-email-2z.png "Select the Settings carat and then select Customizations.")	

3. Select **Customize the System**

    ![Select Customize the System](media\email-how-to-enable-email-2az.png "Select Customize the System.")

4. Expand **Entities**, select and expand **Email**, then select **Forms**

5. On the command bar, select **Form Order** and select **Main Form Set** from the drop-down list

    ![Navigate to Main Form Set](media\email-how-to-enable-email-2bz.png "Select Form Order and then select Main Form Set.")

6. The **Form Order** window appears, which displays enabled email forms that are available. If **Enhanced email** doesn't display at the top of the list, use the arrows to move it up so it displays first on the list. Select **OK**

    ![Form Order window](media\email-how-to-enable-email-2cz.png "Reorder Enhanced email if it doesn't display at the top of the list.")

    > [!Note] 
    > Both the 'Navigate-to' to and 'Contextual' (pop-up) email experience work off of the same **Form Order**.

7.	Once you complete updates, you must **Publish All Customizations** located in the top-left corner for changes to appear; otherwise they will not display.

    ![Select Publish All Customizations](media\email-how-to-enable-email-5az.png "Select Publish All Customizations.")	

## Enable the enhanced email experience	
Enhanced email is the default setting, but you must enable email for users to access and use the feature. 

Sign in to https://<YourOrgURL>.dynamics.com/apps and open a customer engagement app. In the app:	

1. Go to **Settings** and select **Advanced Settings** 

2. In the top nav, select the **Settings** carat (v) then select **Administration** 

   ![Navigate to Administration settings](media\email-how-to-enable-email-5a.png "Navigate to the administration settings.")	

3. Select **System Settings**.

4. In the **System Settings** window that displays, select the **Email** tab. Scroll down to the **Enhanced email for Timeline** section, and then select the box.  

    ![Navigate to the Enhanced email for Timeline option](media\email-how-to-enable-the-enhanced-email-experience-3az.png "Select the Enhanced email for Timeline option.")	

6.	Select **OK** to save your global organizational setting and close.	

## Configure email attachment size limitations

You can manage file size limits for emails file attachments. 

To manage email attachment size limitations, use the following steps: 

1. Select **System Settings**

2. In the **System Settings** display window that appears, go to the **Email** tab. Scroll down to the  **Set file size limit for attachments** section and set file size on attachments. Then select **OK**.

    ![Set size limits for attachments](media\email-how-to-configure-email-attachment-size-limitations-1z.png "Set size limits for attachments.")	

> [!Note] 	
> The default file size limit for attachments is 5 MB. The size limit for attachments can be increased to a maximum of 132 MB per file.

## Configure attachment tiles thumbnail layout

You can configure the attachment tiles thumbnail layout in email by selecting the Email entity form for enhanced email from the Advanced settings menu.

1. In Power Apps, go to **Advanced settings**.

2. Select **Customizations** > **Customize the System**.

3. Select **Entities** > **Email** > **Forms** > **Enhanced Email**.

4. Double-click the **Attachment** area of the form to show the **Properties** dialog.

5. If the **Read Only Grid** control isn't already present, add it by selecting the **Controls** tab and then selecting **Add Control**.

6. After you've added the **Read Only Grid**, you can select it to set the properties you want. Choose from the following:
  - **Reflow Behavior**: Determines whether the layout of a grid changes to a list layout when not enough space is available.
    - **Reflow**: Shown in list mode or grid mode, depending on the available size.
    - **List Only**: Shown in list mode only.
    - **Grid Only**: Shown in grid mode only.
  - **Attachment List Style**: The way individual attachments are displayed in list mode (for the Attachment entity only)
    - **Grid**: Shown in block with multiple attachments per row.
    - **Rows**: Default experience with a single attachments per row.

For example, we'll set **Reflow behavior** to **List Only** and **Attachment list style** to **Rows**, as follows:

   ![Set Reflow behavior and Attachment list style](media\list-attachment-style.png "Set Reflow behavior and Attachment list style.")

These settings display attachments as follows:

   ![Attachments display](media\list-attach-list-display.png "Attachments display.")

Changing to **List** and **Grid** shows the following attachment layout:

   ![List and Grid layout](media\list-grid-layout.png "List and Grid layout.")

### Change the number of attachments to show per page

You can configure the maximum number of attachments to show per page. Adjust the settings on the **Formatting** tab of the **List or Chart properties** dialog. For example, if you set the **Number of Rows** property to 4, and then have more than four attachments per email, the rest of the attachments will paginate and you can then use the arrows buttons to view them.  

 ![Change attachments to show per page](media\email-row-layout.png "Change the number of attachments to show per page.")
 
 ![Pagination display](media\pagination-display.png "Pagination display.")
 

### Manage blocked attachment file types

You can configure the allowed file types for attachments to prevent users from uploading certain files. 

1. In Power Apps, go to **Advanced settings**.

2. Select **System** > **Administration** > **System Settings**.

3. On the **General** tab, scroll down to **Set blocked file extensions for attachments**.

4. Write the file extension(s) you want to block.

 ![Write the file extensions to block](media\set-blocked-extensions-attachments.png "Write the file extensions to block.")
 
  Users who try to upload a blocked file type will see an error message that tells them the attachment is blocked, as follows:

 ![Attachment blocked](media\attachment-blocked-message.png "Attachment blocked message.")

### See Also

[Use email](customer-service-hub-user-guide-email-overview.md)<br>
[Create an email template](customer-service-hub-user-guide-email-create-template.md)<br>
[Insert an email template](customer-service-hub-user-guide-email-insert-template.md)<br>
[Convert an email to a template](customer-service-hub-user-guide-email-convert-template.md)<br>
[Use a signature in email](customer-service-hub-user-guide-email-create-signature.md)<br>
[Email FAQs](email-faqs.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
