---	
title: "Configure email | Microsoft Docs"	
description: "Learn how to configure email."	
ms.date: 10/05/2020	
ms.service:	
    "dynamics-365-customerservice"	
ms.topic: article	
author: lerobbin	
ms.author: lerobbin	
manager: shujoshi	
---	

# Configure email

This experience gives system administrators the ability to configure email templates and enable quick access to email to help users create emails  directly from the timeline so they can deliver a more personalized service.	

How to navigate email configurations	
- [How to configure the email form order](customer-service-hub-user-guide-email-admin.md#how-to-configure-the-email-form-order)	
- [How to enable the enhanced email experience](customer-service-hub-user-guide-email-admin.md#how-to-enable-the-enhanced-email-experience)	
- [How to configure email attachments size limitations](customer-service-hub-user-guide-email-admin.md#how-to-configure-email-attachment-size-limitations)	


## How to configure the email form order	
Email must be enabled for users so they can view and access it. Unless email is enabled, it won't be available as an option on the command bar.	

To enable email:

1. Under **Settings** select **Advanced Settings**

    ![How to enable email](media\email-how-to-enable-email-1z.png "How to enable email")	

2. In the top nav, select the **Settings** carat (v),  then select **Customizations** 

    ![How to enable email](media\email-how-to-enable-email-2z.png "How to enable email")	

3. Select **Customize the System**

    ![How to enable email](media\email-how-to-enable-email-2az.png "How to enable email")

4. Expand **Entities**, select and expand **Email**, then select **Forms**

5. On the command bar, select **Form Order** and select **Main Form Set** from the drop-down list

    ![How to enable email](media\email-how-to-enable-email-2bz.png "How to enable email")

6. The **Form Order** window appears, which displays enabled email forms that are available. If **Enhanced email** doesn't display at the top of the list, use the arrows to move it up so it displays first on the list. Select **OK**

    ![How to enable email](media\email-how-to-enable-email-2cz.png "How to enable email")

    > [!Note] 
    > Both the 'Navigate-to' to and 'Contextual' (pop-up) email experience work off of the same **Form Order**.

7.	Once you complete updates you must **Publish All Customizations** located in the top left corner for changes to appear; otherwise they will not display.

    ![How to enable email](media\email-how-to-enable-email-5az.png "How to enable email")	

## How to enable the enhanced email experience	
Enhanced email is the default setting, but you must enable email for users to access and use the feature. 

Sign in to https://<YourOrgURL>.dynamics.com/apps and open a customer engagement app. In the app:	

1. Go to **Settings** and select **Advanced Settings** 

2. In the top nav, select the **Settings** carat (v) then select **Administration** 

   ![How to enable email](media\email-how-to-enable-email-5a.png "How to enable email")	

3. Select **System Settings**.  
4. In the **System Settings** display window that appears, go to the **Email** tab. Scroll down to the **Enhanced email for Timeline** section and check the box.  

    ![How to enable the enhanced email experience](media\email-how-to-enable-the-enhanced-email-experience-3az.png "How to enable the enhanced email experience")	

6.	Select **OK** to save your global organizational setting and close.	

## How to configure email attachment size limitations

You can manage file size limits for emails file attachments. 

To manage email attachment size limitations, use the following steps: 

1. Select **System Settings**

2. In the **System Settings** display window that appears, go to the **Email** tab. Scroll down to the  **Set file size limit for attachments** section and set file size on attachments. Then select **OK**.

    ![How to configure email attachment size limitations](media\email-how-to-configure-email-attachment-size-limitations-1z.png "How to configure email attachment size limitations")	

> [!Note] 	
> The default file size limit for attachments is 5 MB. The size limit for attachments can be increased to a maximum of 132 MB per file. 	


### See Also	

[Email FAQs](email-faqs.md)