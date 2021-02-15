---
title: "Email activity entities (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "The email activity in Dynamics 365 Customer Engagement lets you track and manage email communications with customers."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - bulk email, process sequence
  - email activity entities, attaching files to email
  - email activity entities, process sequence for bulk email
  - attaching files to email
  - tracking and managing customer email
  - email attachments, maximum and default sizes
  - email activity entities, introduction
  - email activity entities, sending bulk email
  - email activity entities, blocked email
  - using email templates
  - sending bulk email
  - email routing, software for
  - email activity entities, email templates
  - email activity entities, tracking and managing customer email
  - email activity entities, approved users and queues
  - templates, email
  - blocked email
  - configuring email delivery
  - email attachments, reusing (saved as BLOBs)
  - email routing, supported protocols
  - email activity entities
  - email attachments, about
  - email actions, creating, retrieving, updating, deleting
  - email activity entities, configuring delivery
  - email activity entities, routing email
ms.assetid: 4c27c9ae-c0e8-4de4-bba7-bf957a873ff5
caps.latest.revision: 42
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Email activity entities

The email activity lets you track and manage email communications with customers. [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] includes the Email Router software that manages the routing of email to or from [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]. The email activity is delivered using email protocols. Email Router supports the following email protocols: Exchange Web services, POP3, and SMTP. In addition to the Email Router software, the email activity can also be delivered by using [!INCLUDE[pn_crm_for_outlook_full](../includes/pn-crm-for-outlook-full.md)].  
  
<a name="Actions"></a>   
## Actions on an Email Activity  
 Using [!INCLUDE[cc-dyn365-ce-web-services](../includes/cc-dyn365-ce-web-services.md)], you can perform the following actions on an email activity:  
  
- Create, retrieve, update, and delete the email activity.  
  
- Send email messages, or send email messages by using email templates (`Template`). For more information about email templates, see [Template Entity](entities/template.md).  
  
- Attach files as attachments by using the (`ActivityMimeAttachment`) attribute in the email message.  
  
- Send mass or bulk email messages.  
  
- Configure incoming email messages to be delivered from [!INCLUDE[pn_Exchange_Server_full](../includes/pn-exchange-server-full.md)] to any user or queue, or outgoing messages to be sent from any user or queue to [!INCLUDE[pn_Exchange_Server_full](../includes/pn-exchange-server-full.md)]. For information about how to configure incoming email messages for queues, see  [Configure email for incoming messages](configure-email-incoming-messages.md).  
  
   If the `Organization.RequireApprovalForuserEmail` and `Organization.RequireApprovalForQueueEmail` (process emails only for approved users/queues) organization attributes are set to **true** (1),  the following occurs: email messages are delivered or sent from a user or queue only if the primary email address of the user or queue is approved. The `SystemUser.EmailRouterAccessApproval` and the `Queue.EmailRouterAccessApproval` attributes indicate the status of the primary email address of the user and queue respectively, and the value must be set to 1. Otherwise, the incoming and outgoing messages will be blocked. You can update the user or queue record to change the attribute value, if it is not already in the approved state, provided your user account has the **prvApproveRejectEmailAddress** privilege assigned.
  
> [!NOTE]
>  In [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)], the `Email.StatusCode` attribute cannot be **null**.  
  
<a name="BulkE-Mail"></a>   
## Bulk Email  
 [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] supports sending email to a large list of recipients through a bulk email request. When a bulk email request is sent to [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)], an asynchronous operation is created in the asynchronous service queue that sends the email messages by using a background process. This gives you improved system performance.  
  
 The <xref:Microsoft.Crm.Sdk.Messages.SendBulkMailRequest> and <xref:Microsoft.Crm.Sdk.Messages.BackgroundSendEmailRequest> messages are used for sending bulk email messages. The following lists the sequence used to send bulk email:  
  
1. Execute the `SendBulkMail` request. This request contains a query that selects the target email recipients and an email template for composing each email.  
  
2. The asynchronous service creates the email activities for each recipient.  
  
3. The asynchronous service sends each email message. The email messages have a "pending" send status.  
  
4. The email router, [!INCLUDE[pn_crm_for_outlook_full](../includes/pn-crm-for-outlook-full.md)], or a third-party email send component polls [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] for pending email messages, and if one is found, downloads it by using the `BackgroundSendEmail` request.  
  
5. The `BackgroundSendEmail` request performs the following operations: checks if pending email messages are present, downloads the email to the caller of the <xref:Microsoft.Crm.Sdk.Messages.BackgroundSendEmailRequest> message, and synchronizes the downloads if there are multiple callers.  
  
6. The caller of the <xref:Microsoft.Crm.Sdk.Messages.BackgroundSendEmailRequest> message receives the downloaded email message, and sends it out.  
  
<a name="E-MailAttachments"></a>   
## Email Attachments  
 Email attachments are files that can be attached to email messages or email templates. An attached file can be in any standard computer file format such as [!INCLUDE[pn_MS_Word_Full](../includes/pn-ms-word-full.md)] documents, [!INCLUDE[pn_MS_Excel_Full](../includes/pn-ms-excel-full.md)] spreadsheets, CAD files, and PDF files. You can attach multiple files as email attachments to an email or email template. [!INCLUDE[sdk_MaxUploadFileSize](../includes/sdk-maxuploadfilesize.md)]  
  
 To attach an email attachment with an email message or template, you use the `ActivityMimeAttachment.ObjectId` and `ActivityMimeAttachment.ObjectTypeCode` attributes while you are creating or updating an activity mime attachment record.  
  
 The following code sample shows how to attach an email attachment to an email:  
  
```csharp  
ActivityMimeAttachment _sampleAttachment = new ActivityMimeAttachment{  
    ObjectId = new EntityReference(Email.EntityLogicalName, _emailId),  
    ObjectTypeCode = Email.EntityLogicalName,  
    Subject = "Sample Attachment”,  
    Body = System.Convert.ToBase64String(new ASCIIEncoding().GetBytes("Example Attachment")),  
    FileName = "ExampleAttachment.txt"};  
```  
  
 Similarly, to attach the email attachment to a template instead of an email, you will replace the values of the `ActivityMimeAttachment.ObjectId` and `ActivityMimeAttachment.ObjectTypeCode` attributes as follows in the above code:  
  
```csharp  
ObjectId = new EntityReference(Template.EntityLogicalName, _templateId), ObjectTypeCode = Template.EntityLogicalName,  
```  
  
 For complete code sample about how to create email attachments, see [Sample: Create, Retrieve, Update, and Delete an E-Mail Attachment](sample-create-retrieve-update-delete-email-attachment.md).  
  
### Reusing Email Attachments  
 When you create an email attachment record, the attached file is saved as a file BLOB. The `ActivityMimeAttachment.AttachmentId` attribute of the email attachment record uniquely identifies the file BLOB. This is done to facilitate the reuse of the file attachments with other email and email template records, without creating and storing multiple copies of the same file in the database.  
  
 To reuse an existing file attachment:  
  
1.  Retrieve the `ActivityMimeAttachment` record that contains the attachment file that you want to re-use, as shown in the following code example:  
  
    ```csharp  
    ActivityMimeAttachment retrievedAttachment = (ActivityMimeAttachment)_serviceProxy.Retrieve(ActivityMimeAttachment.EntityLogicalName, _emailAttachmentId, new ColumnSet(true));  
    ```  
  
2.  Create a new email attachment record, associate it with the required email or email template record, and point it to the attached file of the retrieved `ActivityMimeAttachment` record, as shown in the following code example:  
  
    ```csharp  
    ActivityMimeAttachment _reuseAttachment = new ActivityMimeAttachment{  
        ObjectId = new EntityReference(Email.EntityLogicalName, _emailId),  
        ObjectTypeCode = Email.EntityLogicalName,  
        Subject = "Sample Attachment”,  
        AttachmentId = retrievedAttachment.AttachmentId};  
    ```  
  
     Because you are reusing an existing attachment file, you do not have to specify the `ActivityMimeAttachment.Body` and `ActivityMimeAttachment.FileName` attribute values while you are creating and associating email attachment records to emails or email templates.  
  
### See also  
 [Activity Entities](activity-entities.md)   
 [Sample code for activity entities](sample-code-activity-entities.md)   
 [Email Entity](entities/email.md)   
 [ActivityMimeAttachment Entity](entities/activitymimeattachment.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]