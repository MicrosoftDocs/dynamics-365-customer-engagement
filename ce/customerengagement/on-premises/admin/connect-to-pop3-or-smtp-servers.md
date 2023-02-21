---
title: "Connect IMAP, POP, or SMTP servers to Dynamics 365 Customer Engagement (on-premises)"
description: "Follow these steps to connect Customer Engagement (on-premises) with IMAP/POP3/SMTP email servers, such as those used for Gmail and Yahoo! Mail."
ms.custom: 
ms.date: 02/21/2023
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement  (online)
ms.assetid: afb01c24-a2bd-4e00-9804-ce494f2d315b
caps.latest.revision: 22
author: sericks007
ms.author: sericks
search.audienceType: 
  - admin
---
# Connect Customer Engagement (on-premises) to IMAP, POP, or SMTP servers

::: moniker range="op-9-1"
[!INCLUDE [cc-use-advanced-settings](../includes/cc-use-advanced-settings.md)]
::: moniker-end

Follow these steps to connect Dynamics 365 Customer Engagement (on-premises) with IMAP, POP3, or SMTP email servers, such as used for Gmail and Yahoo! Mail.  

> [!NOTE]
>  
>  For IMAP/POP3/SMTP systems supported by Microsoft, check out the following topic: [Supported email service configurations for server-side synchronization](supported-email-service-configurations-server-side-synchronization.md).  

> [!NOTE]
>  
> Starting with version 9.1, Online Certificate Status Protocol (OCSP) is used to validate certificate revocation status. If you're using Customer Engagement (on-premises), ensure the Dynamics 365 asynchronous service has proper network access to connect to the certificate authorities and use OCSP. If network access is blocked, you may see an alert like the following logged in the mailbox:
>  
> "Unable to send email messages for the ... mailbox because a server certificate needed to connect to the email server could not be validated or the credentials used to send the messages were not are correct or do not provide access.
> Error : MailKit.Security.SslHandshakeException: An error occurred while attempting to establish an SSL or TLS connection."

<a name="BKMK_CreateProfile"></a>   
## Create an email server profile  

1. Go to **Settings** > **Email Configuration** > **Email Server Profiles**.  

2. Select **New** > **IMAP/SMTP Server**.  

3. **For a Yahoo email server profile, specify the following details:**  


   |  Fields  |     Description      |
   |-----------|----------|   
   |   **General**      |     |   
   | Name     |  Specify a meaningful name for the profile.   |   
   |   Description   |  Enter a short description about the objective of the email server profile.       |
   | Incoming Server Location and Outgoing Server Location  |  Enter the **Incoming Server Location** and **Outgoing Server Location**.<br /><br />For example:<br><br> **Incoming Server Location:** `imap.mail.yahoo.com`<br>**Outgoing Server Location:** `smtp.mail.yahoo.com`  |
   |  **Credentials**  |    |
   |  Authenticate Using  | Select a method to authenticate while connecting to the specified email server.<br /><br /> <ul><li>**Credentials Specified by a User or Queue:** If you select this option, the credentials specified in the mailbox record of a user or queue are used for sending or receiving email for the respective user or queue.<br><br>**Note:** To ensure that the credentials are secured, SQL encryption is used to encrypt the credentials stored in the mailbox.</li><br /><li> **Credentials Specified in Email Server Profile:** If you select this option, the credentials specified in the email server profile are used for sending or receiving email for the mailboxes of all users and queues associated with this profile. The credentials must have impersonation or delegation permissions on the mailboxes associated with the profile. This option requires some configuration on the email server, for example, configuring impersonation rights on Exchange for the mailboxes associated with the profile.<br><br>**Note:** To ensure that the credentials are secured, SQL encryption is used to encrypt the credentials stored in the email server profile if you're processing email by using server-side synchronization.</li><br /><li>**Windows Integrated Authentication:** This option applies only to Exchange and SMTP email server types. If you select this option, the credentials with which the Asynchronous Service has been configured will be used.</li><br /><li> **Without Credentials (Anonymous):** Not a valid setting. </li></ul>|
   | User Name   | Enter the username used to connect to the email server for sending or receiving email for the mailboxes of all users and queues associated with this profile. This field is enabled and valid only if **Authenticate Using** is set to **Credentials Specified in Email Server Profile**. The username that you specify must have permission to send and receive email from the mailboxes of users and queues associated with this profile.<br><br>**Note:**  If you're using HTTP for customer engagement apps, the **User Name** and **Password** fields will be disabled. To enable the option, change the value of the deployment property AllowCredentialsEntryViaNonSecureChannels to 1.  |
   |  Password   |  Specify the password of the user that will be used together with the username to connect to the email server for sending or receiving email for the mailboxes of users and queues associated with this profile. The password is stored securely.<br><br>**Note:** If you're using HTTP for customer engagement apps, the **User Name** and **Password** fields will be disabled. To enable the option, change the value of the deployment property AllowCredentialsEntryViaNonSecureChannels to 1. |
   | Use same settings for Outgoing |  If you want to use the same credential settings for the incoming and outgoing connections, choose **Yes**.  |
   | **Advanced**    |  |
   |  Incoming Port  | This field shows the port on the email server for accessing the incoming email. This field is automatically populated when you save the record.   |
   |  Outgoing Port  | This field shows the port on the email server for accessing the outgoing email. This field is automatically populated when you save the record.   |
   | Use SSL for Incoming Connection    |  Choose **Yes** if the email channel is on a secure channel and TLS/SSL must be used for receiving email.   |
   | Use SSL for Outgoing Connection |  Choose **Yes** if the email channel is on a secure channel and TLS/SSL must be used for sending email.  |
   | Incoming Authentication Protocol and Outgoing Authentication Protocol |  Select a protocol that will be used for authentication for incoming and outgoing email.  |
   |   **Additional Settings**  |  |
   |  Process Email From |  Select a date and time. Email received after the date and time will be processed by server-side synchronization for all mailboxes associated with this profile. If you set a value earlier than the current date, the change will be applied to all newly associated mailboxes, and their emails that were processed earlier will be pulled.  |
   | Minimum Polling Intervals in Minutes  |  Enter the minimum polling interval, in minutes, for mailboxes that are associated with this email server profile. The polling interval determines how often server-side synchronization polls your mailboxes for new email messages.  |
   |  Maximum Concurrent Connections   | Enter the maximum number of simultaneous connections that can be made to the corresponding email server, per mailbox. Increase the value to allow more parallel calls to Exchange to improve performance, or reduce the value if there are errors on Exchange due to a large number of calls from customer engagement apps. The default value of this field is 10. The maximum number is considered per mailbox or per email server profile, depending on whether the credentials are specified in a mailbox or email server profile.   |

4. Select **Save**.  

<a name="BKMK_ConfigureDefault"></a>   
## Configure default email processing and synchronization  
 Set server-side synchronization to be the default configuration method.  

1. Go to **Settings** > **Email Configuration** > **Email Configuration Settings**.  

2. Set the processing and synchronization fields as follows:  

   - **Server Profile**: The profile you created in the above section.  

   - **Incoming Email**: Server-Side Synchronization or Email Router  

   - **Outgoing Email**: Server-Side Synchronization or Email Router  

   - **Appointments, Contacts, and Tasks**: Server-Side Synchronization or Email Router  

     > [!NOTE]
     >  Server-Side Synchronization or Email Router for Appointments, Contacts, and Tasks is not supported for the POP3-SMTP profile.  

     If you leave the **Email processing form unapproved user and queues** at the default values (checked), you will need to approve emails and queues for user mailboxes as directed below in **Approve Email**.  

     ![System Settings for server-side synchronization.](../admin/media/crm-itpro-exchangeonlinessssettingspop.png "System Settings for server-side synchronization")  

3.  Click **OK**.  

<a name="BKMK_ConfigureMailboxes"></a>   
## Configure mailboxes  
 To set mailboxes to use the default profile, you must first set the Server Profile and the delivery method for email, appointments, contacts, and tasks.  

 In addition to administrator permissions, you must have Read and Write privileges on the Mailbox entity to set the delivery method for the mailbox.  

 Click **one** of the following methods:  

#### Set mailboxes to the default profile  

1. Go to **Settings** > **Email Configuration** > **Mailboxes**.  

2. Choose **Active Mailboxes**.  

3. Select all the mailboxes that you want to associate with the POP3-SMTP profile you created, click **Apply Default Email Settings**, verify the settings, and then click **OK**.  

   ![Apply default email settings.](../admin/media/apply-default-email-settings.png "Apply default email settings")  

    By default, the mailbox configuration is tested and the mailboxes are enabled when you click **OK**.  

#### Edit mailboxes to set the profile and delivery methods  

1.  Go to **Settings** > **Email Configuration** > **Mailboxes**.  

2.  Click **Active Mailboxes**.  

3.  Select the mailboxes that you want to configure, and then click **Edit**.  

4.  In the **Change Multiple Records** form, under **Synchronization Method**, set **Server Profile** to the POP3-SMTP profile you created earlier.  

5.  Set **Incoming** and **Outgoing** **Email** to **Server-Side Synchronization or Email Router**.  

6.  Set **Appointments, Contacts, and Tasks** to **None**.  


7.  Click **Change**.  

<a name="BKMK_ApproveEmail"></a>   
## Approve email  
 You need to approve each user mailbox or queue before that mailbox can process email.  

1.  Go to **Settings** > **Email Configuration** > **Mailboxes**.  

2.  Click **Active Mailboxes**.  

3.  Select the mailboxes that you want to approve, and then click **More Commands** (**…**) > **Approve Email**.  

4.  Click **OK**.  

<a name="BKMK_TestConfiguration"></a>   
## Test configuration of mailboxes  

1. Go to **Settings** > **Email Configuration** > **Mailboxes**.  

2. Click **Active Mailboxes**.  

3. Select the mailboxes you want to test, and then click **Test & Enable Mailboxes**.  

    This tests the incoming and outgoing email configuration of the selected mailboxes and enables them for email processing. If an error occurs in a mailbox, an alert is shown on the Alerts wall of the mailbox and the profile owner. Depending on the nature of the error, Customer Engagement (on-premises) tries to process the email again after some time or disables the mailbox for email processing.  

    The result of the email configuration test is displayed in the **Incoming Email Status**, **Outgoing Email Status**, and **Appointments, Contacts, and Tasks Status** fields of a mailbox record. An alert is also generated when the configuration is successfully completed for a mailbox. This alert is shown to the mailbox owner.  

    You can find information on recurring issues and other troubleshooting information in [Blog: Test and Enable Mailboxes in Microsoft Dynamics CRM 2015](https://blogs.msdn.com/b/crm/archive/2015/08/31/test-and-enable-mailboxes-in-microsoft-dynamics-crm-2015.aspx) and [Troubleshooting and monitoring server-side synchronization](troubleshooting-monitoring-server-side-synchronization.md).  

> [!TIP]
>  If you’re unable to synchronize contacts, appointments, and tasks for a mailbox, you may want to select the **Sync items with Exchange from this org only, even if Exchange was set to sync with a different org** check box. [Read more about this check box](when-would-want-use-check-box.md).  

<a name="BKMK_TestEmailConfig"></a>   

## Test email configuration for all mailboxes associated with an email server profile  

1. Go to **Settings** > **Email Configuration** > **Email Server Profiles**.  

2. Select the profile you created, and then click **Test & Enable Mailboxes**.  

    When you test the email configuration, an asynchronous job runs in the background. It may take a few minutes for the test to be completed. Customer Engagement (on-premises) tests the email configuration of all the mailboxes associated with the POP3-SMTP profile. For the mailboxes configured with server-side synchronization for synchronizing appointments, tasks, and contacts, it also checks to make sure they’re configured properly.  

> [!TIP]
>  If you’re unable to synchronize contacts, appointments, and tasks for a mailbox, you may want to select the **Sync items with Exchange from this org only, even if Exchange was set to sync with a different org** check box. [Read more about this check box](when-would-want-use-check-box.md).  

### See also  
 [Troubleshooting and monitoring server-side synchronization](troubleshooting-monitoring-server-side-synchronization.md) <br />
 [Test mail flow with the Remote Connectivity Analyzer](https://technet.microsoft.com/library/dn305950\(v=exchg.150\).aspx)   
 [Set up server-side synchronization](set-up-server-side-synchronization-of-email-appointments-contacts-and-tasks.md)   



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
