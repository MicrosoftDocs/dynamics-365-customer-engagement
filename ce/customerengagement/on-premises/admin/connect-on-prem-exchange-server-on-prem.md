---
title: "Connect Dynamics 365 (on-premises) to Exchange Server (on-premises) | MicrosoftDocs"
ms.custom: ""
ms.date: 11/28/2018
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 87e822ff-be12-4429-a130-a76b832eebb4
caps.latest.revision: 42
author: "jimholtz"
ms.author: "jimholtz"
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - Powerplatform
---
# Connect Dynamics 365 (on-premises) to Exchange Server (on-premises)

[!INCLUDE[cc_applies_to_on-prem-9_0_0](../includes/cc_applies_to_on-prem-9_0_0.md)]

Follow these steps to connect Dynamics 365 (on-premises) with Microsoft Exchange Server (on-premises).

## Create an email server profile

1.  Go to **Settings** > **Email Configuration** > **Email Server Profiles**.

2.  Click **New** > **Exchange Server**.

3.  **For an Exchange email server profile, specify the following details:**

    <table>
    <colgroup>
    <col style="width: 50%" />
    <col style="width: 50%" />
    </colgroup>
    <thead>
    <tr class="header">
    <th><p>Fields</p></th>
    <th><p>Description</p></th>
    </tr>
    </thead>
    <tbody>
    <tr class="odd">
    <td><p><strong>General</strong></p></td>
    <td><p></p></td>
    </tr>
    <tr class="even">
    <td><p>Name</p></td>
    <td><p>Specify a meaningful name for the profile.</p></td>
    </tr>
    <tr class="odd">
    <td><p>Description</p></td>
    <td><p>Type a short description about the objective of the email server profile.</p></td>
    </tr>
    <tr class="even">
    <td><p>Auto Discover Server Location</p></td>
    <td><p>Click <strong>Yes</strong> if you want to use the automatically discover service to determine the server location. If you set this to <strong>No</strong>, you must specify the email server location manually.</p>

    > [!NOTE]
    > <P>If the server location doesn’t change for mailboxes, we recommend that you don’t use auto discover because it may affect performance.</P>
    </td>
    </tr>
    <tr class="odd">
    <td><p>Incoming Server Location and Outgoing Server Location</p></td>
    <td><p>If you select <strong>No</strong> in <strong>Auto Discover Server Location</strong>, enter a URL for <strong>Incoming Server Location</strong> and <strong>Outgoing Server Location</strong>.</p></td>
    </tr>
    <tr class="even">
    <td><p><strong>Credentials</strong></p></td>
    <td><p></p></td>
    </tr>
    <tr class="odd">
    <td><p>Authenticate Using</p></td>
    <td><p>Select a method to authenticate while connecting to the specified email server. What’s available depends on whether you are using an online or on-premises version of Dynamics 365.</p>
    <ul>
    <li><p><strong>Credentials Specified by a User or Queue</strong>. If you select this option, the credentials specified in the mailbox record of a user or queue are used for sending or receiving email for the respective user or queue.</p>

    > [!NOTE]
    > <P>To ensure the credentials are secured in Microsoft Dynamics 365, SQL encryption is used to encrypt the credentials stored in the mailbox.</P>
    </li>
    <li><p><strong>Credentials Specified in Email Server Profile</strong>. If you select this option, the credentials specified in the email server profile are used for sending or receiving email for the mailboxes of all users and queues associated with this profile. The credentials must have impersonation or delegation permissions on the mailboxes associated with profile. This option requires some configuration on the email server, for example, configuring impersonation rights on Exchange for the mailboxes associated with the profile.</p>

    > [!NOTE]
    > <P>To ensure the credentials are secured in Microsoft Dynamics 365, SQL encryption is used to encrypt the credentials stored in the email server profile if you’re processing email by using server-side synchronization.</P>
    </li>
    <li><p><strong>Windows Integrated Authentication</strong>. If you select this option, the credentials with which the Microsoft Dynamics 365 Asynchronous Service has been configured will be used.</p></li>
    <li><p><strong>Without Credential (Anonymous)</strong>. Not a valid setting.</p></li>
    </ul></td>
    </tr>
    <tr class="even">
    <td><p>User Name</p></td>
    <td><p>Type the user name used to connect to the email server for sending or receiving email for the mailboxes of all users and queues associated with this profile. This field is enabled and valid only if <strong>Authenticate Using</strong> is set to <strong>Credentials Specified in Email Server Profile</strong>. The user name that you specify must have permission to send and receive email from the mailboxes of users and queues associated with this profile.</p>

    > [!NOTE]
    > <P>If you’re using HTTP for Microsoft Dynamics 365, the <STRONG>User Name</STRONG> and <STRONG>Password</STRONG> fields will be disabled. To enable the option, change the value of the deployment property AllowCredentialsEntryViaNonSecureChannels to 1.</P>
    </td>
    </tr>
    <tr class="odd">
    <td><p>Password</p></td>
    <td><p>Specify the password of the user that will be used together with the user name to connect to the email server for sending or receiving email for the mailboxes of users and queues associated with this profile. The password is stored securely.</p>

    > [!NOTE]
    > <P>If you’re using HTTP for Microsoft Dynamics 365, the <STRONG>User Name</STRONG> and <STRONG>Password</STRONG> fields will be disabled. To enable the option, change the value of the deployment property AllowCredentialsEntryViaNonSecureChannels to 1.</P>
    </td>
    </tr>
    <tr class="even">
    <td><p>Use same settings for Outgoing</p></td>
    <td><p>If you want to use the same credential settings for the incoming and outgoing connections, click <strong>Yes</strong>.</p></td>
    </tr>
    <tr class="odd">
    <td><p><strong>Advanced</strong></p></td>
    <td><p></p></td>
    </tr>
    <tr class="even">
    <td><p>Incoming Authentication Protocol and Outgoing Authentication Protocol</p></td>
    <td><p>Select a protocol that will be used for authentication for incoming and outgoing email.</p></td>
    </tr>
    <tr class="odd">
    <td><p><strong>Additional Settings</strong></p></td>
    <td><p></p></td>
    </tr>
    <tr class="even">
    <td><p>Process Email From</p></td>
    <td><p>Select a date and time. Email received after the date and time will be processed by server-side synchronization for all mailboxes associated with this profile. If you set a value less than the current date, the change will be applied to all newly associated mailboxes and their earlier processed emails will be pulled.</p></td>
    </tr>
    <tr class="odd">
    <td><p>Minimum Polling Intervals in Minutes</p></td>
    <td><p>Type the minimum polling interval, in minutes, for mailboxes that are associated with this email server profile. The polling interval determines how often server-side synchronization polls your mailboxes for new email messages.</p></td>
    </tr>
    <tr class="even">
    <td><p>Maximum Concurrent Connections</p></td>
    <td><p>Type the maximum number of simultaneous connections that can be made by Dynamics 365 to the corresponding email server per mailbox. Increase the value to allow more parallel calls to Exchange to improve performance or reduce the value if there are errors on Exchange due to large number of calls from Microsoft Dynamics 365. The default value of this field is 10. The maximum number is considered per mailbox or per email server profile depending on whether the credentials are specified in a mailbox or email server profile.</p></td>
    </tr>
    <tr class="odd">
    <td><p>Move Failed Emails to Undeliverable Folder</p></td>
    <td><p>To move the undelivered email to the Undeliverable folder, click <strong>Yes</strong>. If there’s an error in tracking email messages in Dynamics 365 as email activities, and if this option is set to <strong>Yes</strong>, the email message will be moved to the Undeliverable folder. This option is available only for an Exchange email server profile.</p></td>
    </tr>
    </tbody>
    </table>

4.  Click **Save**.

## Configure default email processing and synchronization

Set server-side synchronization to be the default configuration method.

1.  Go to **Settings** > **Email Configuration** > **Email Configuration Settings**.

2.  Set the processing and synchronization fields as follows:
    
      - **Server Profile**: The profile you created in the above section.
    
      - **Incoming Email**: Server-Side Synchronization or Email Router
    
      - **Outgoing Email**: Server-Side Synchronization or Email Router
    
      - **Appointments, Contacts, and Tasks**: Server-Side Synchronization or Email Router
        

        > [!NOTE]
        > If your users primarily use Dynamics 365 for Outlook on their desktop computers, **Microsoft Dynamics 365 for Outlook** might be a better choice.

    
    If you leave the **Email processing form unapproved user and queues** at the default values (checked), you will need to approve emails and queues for user mailboxes as directed below in **Approve Email**.
    
    ![System Settings for server-side synchronization](media/system-settings-synch-method.png "System Settings for server-side synchronization")

3.  Click **OK**.

## Configure mailboxes

To set mailboxes to use the default profile, you must first set the Server Profile and the delivery method for email, appointments, contacts, and tasks.

In addition to administrator permissions, you must have Read and Write privileges on the Mailbox entity to set the delivery method for the mailbox.

Select **one** of the following methods:

## Set mailboxes to the default profile

1.  Go to **Settings** > **Email Configuration** > **Mailboxes**.

2.  Click **Active Mailboxes**.

3.  Select all the mailboxes that you want to associate with the Exchange Server profile you created, click **Apply Default Email Settings**, verify the settings, and then click **OK**.
    
    ![Apply default email settings](media/apply-default-email-settings.png "Apply default email settings")
    
    By default, the mailbox configuration is tested and the mailboxes are enabled when you click **OK**.

## Edit mailboxes to set the profile and delivery methods

1.  Go to **Settings** > **Email Configuration** > **Mailboxes**.

2.  Click **Active Mailboxes**.

3.  Select the mailboxes that you want to configure, and then click **Edit**.

4.  In the **Change Multiple Records** form, under **Synchronization Method**, set **Server Profile** to the Exchange Server profile you created earlier.

5.  Set **Incoming** and **OutgoingEmail** to **Server-Side Synchronization or Email Router**.

6.  Set **Appointments, Contacts, and Tasks** to **Server-Side Synchronization**.
    

    > [!NOTE]
    > If your users primarily use Dynamics 365 for Outlook on their desktop computers, <STRONG>Microsoft Dynamics 365 for Outlook</STRONG> might be a better choice.

7.  Click **Change**.

## Approve email

You need to approve each user mailbox or queue before that mailbox can process email.

1.  Go to **Settings** > **Email Configuration** > **Mailboxes**.

2.  Click **Active Mailboxes**.

3.  Select the mailboxes that you want to approve, and then click **More Commands** (**…**) > **Approve Email**.

4.  Click **OK**.

## Test configuration of mailboxes

1.  Go to **Settings** > **Email Configuration** > **Mailboxes**.

2.  Click **Active Mailboxes**.

3.  Select the mailboxes you want to test, and then click **Test & Enable Mailboxes**.
    
    This tests the incoming and outgoing email configuration of the selected mailboxes and enables them for email processing. If an error occurs in a mailbox, an alert is shown on the Alerts wall of the mailbox and the profile owner. Depending on the nature of the error, Microsoft Dynamics 365 tries to process the email again after some time or disables the mailbox for email processing.
    
    The result of the email configuration test is displayed in the **Incoming Email Status**, **Outgoing Email Status**, and **Appointments, Contacts, and Tasks Status** fields of a mailbox record. An alert is also generated when the configuration is successfully completed for a mailbox. This alert is shown to the mailbox owner.
    
    You can find information on recurring issues and other troubleshooting information in [Troubleshooting and monitoring server-side synchronization](troubleshooting-monitoring-server-side-synchronization.md).

> [!TIP]
> If you’re unable to synchronize contacts, appointments, and tasks for a mailbox, you may want to select the **Sync items with Exchange from this Dynamics 365 org only, even if Exchange was set to sync with a different org** check box. [Read more about this check box](https://go.microsoft.com/fwlink/p/?linkid=391868).

## Test email configuration for all mailboxes associated with an email server profile

1.  Go to **Settings** > **Email Configuration** > **Email Server Profiles**.

2.  Select the profile you created, and then click **Test & Enable Mailboxes**.
    
    When you test the email configuration, an asynchronous job runs in the background. It may take a few minutes for the test to be completed. Microsoft Dynamics 365 tests the email configuration of all the mailboxes associated with the Exchange Server profile. For the mailboxes configured with server-side synchronization for synchronizing appointments, tasks, and contacts, it also checks to make sure they’re configured properly.

> [!TIP]
> If you’re unable to synchronize contacts, appointments, and tasks for a mailbox, you may want to select the **Sync items with Exchange from this Dynamics 365 org only, even if Exchange was set to sync with a different org** check box. [Read more about this check box](https://go.microsoft.com/fwlink/p/?linkid=391868).



