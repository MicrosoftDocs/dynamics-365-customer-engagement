---
title: "Create users and assign security roles | MicrosoftDocs"
ms.custom: 
ms.date: 10/01/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement  (online)
  - Dynamics 365 for Customer Engagement  Version 9.x
ms.assetid: 5f21f288-f941-4ca0-a15f-a91cd9feee4d
caps.latest.revision: 4
author: jimholtz
ms.author: jimholtz
search.audienceType: 
  - admin

---
# Create users and assign security roles

::: moniker range="op-9-1"
[!INCLUDE [cc-use-advanced-settings](../includes/cc-use-advanced-settings.md)]
::: moniker-end

With Dynamics 365 Customer Engagement (on-premises), you can add users to your organization one at a time, or add multiple users at the same time by using the **Add Users** wizard.

### Add a user

1.  Go to **Settings** > **Security**.

2.  Choose **Users**.

3.  On the toolbar, choose **New**.

4.  On the **New User** page, in the **Account Information** section, specify the **User Name** for the user.

5.  In the **User Information** section, specify the **Full Name** for the user.

6.  In the **Organization Information** section, verify the **Business Unit** for the user.

7.  Follow the step for the task you’re doing:
    
      - To save the information for the new user, choose **Save**.
    
      - To save the information for the user and add another user, choose **Save & New**.
    
      - To add another user without saving the information you entered for the user, choose **New**, and then in the **Message from webpage** dialog box, choose **OK**.
    
    Next, you’ll need to assign a security role to the newly added user. See “Assign a security role to a user” later in this topic.

### Add multiple users

You can add multiple user records for the same set of security roles by using the Add Users wizard. Any users you add must be in the Active Directory directory service.

1.  Go to **Settings** > **Security**.

2.  Choose **Users**.

3.  On the toolbar, choose **New Multiple Users**.
    
    The **Add Users** wizard opens.

4.  On the **Select Security Roles** page, select one or more security roles, and then choose **Next**.

5.  On the **Select Access and License Type** page, under **Access Type**, select the appropriate access type for this set of users.

6.  Under **License Type**, specify the license type for this set of users.

7.  Under **Email Access Configuration**, specify how this set of users will access incoming and outgoing email messages, and then choose **Next**.

8.  On the **Select Domain or Group** page, specify to select users from all trusted domains and groups or users from a particular domain or group, and then choose **Next**.

9.  On the **Select Users** page, type a part of the name of user you want to add to Microsoft Dynamics 365. Use semi-colons between names.
    
10. Choose **Create New Users**.

11. On the **Summary** page, review the information about the user additions, and then follow the step for the task you are performing:
    
      - To close the Add Users wizard, choose **Close**.
    
      - If you need to add more users, for example with a different set of security roles, choose **Add More Users** to begin the wizard again.
    

    > [!NOTE]
    > To edit a specific user record, close the wizard, and then open the user record from the list.

### Assign a security role to a user

After you create users, you must assign security roles for them to use Customer Engagement (on-premises). Even if a user is a member of a team with its own security privileges, the user won’t be able to see some data and may experience other problems when trying to use the system. More information: [Security roles and privileges](security-roles-privileges.md)

1.  Go to **Settings** > **Security**.

2.  Choose **Users**.

3.  In the list, select the user or users that you want to assign a security role to.

4.  Choose **More Commands** (***...***) > **Manage Roles**.
    
    Only the security roles available for that user's business unit are displayed.

5.  In the **Manage User Roles** dialog box, select the security role or roles you want for the user or users, and then choose **OK**.


### Enable a user

1.  Go to **Settings** > **Security**.

2.  Select **Users**.

3.  Select the down arrow next to **Enabled Users**, and then choose **Disabled Users**.

4.  Select the checkmark next to the user you want to enable, and on the Actions toolbar, select **Enable**.

5.  In the **Confirm User Activation** message, select **Activate**.

## Disable a user

> [!NOTE]
> You can [assign records](https://docs.microsoft.com/dynamics365/customer-engagement/basics/assign-record-user-team) to a disabled user and also [share reports](https://docs.microsoft.com/dynamics365/customer-engagement/basics/share-report-users-teams) and accounts with them. This can be useful when migrating on-premises versions to online. If you need to assign a security role to users who have a Disabled status, you can do so by enabling the allowRoleAssignmentOnDisabledUsers [OrgDBOrgSettings](https://support.microsoft.com/help/2691237/orgdborgsettings-tool-for-microsoft-dynamics-crm).

1.  Go to **Settings** > **Security**.

2.  Choose **Users**.

3.  In the **Enabled Users** view, select the checkmark next to the user you want to disable.

4.  On the Actions toolbar, select **Disable**.

5.  In the **Confirm User Record Deactivation** message, select **Deactivate**.

### Update a user record to reflect changes in Active Directory

When you create a new user or update an existing user in Customer Engagement (on-premises), some fields in the Customer Engagement (on-premises) user records, such as the name and phone number, are populated with the information obtained from Active Directory Domain Services (AD DS). After the user record is created in Customer Engagement (on-premises), there is no further synchronization between Active Directory user accounts and Customer Engagement (on-premises) user records. If you make changes to the Active Directory user account, you must manually edit the Customer Engagement (on-premises) user record to reflect the changes.

1.  Go to **Settings** > **Security**.

2.  Choose **Users**.

3.  In the list, select the user you want to update, and then choose **Edit**.

The following table shows the fields that are populated on the Customer Engagement (on-premises) user form (user record) from the Active Directory user account:

<table>
<colgroup>
<col style="width: 33%" />
<col style="width: 33%" />
<col style="width: 33%" />
</colgroup>
<thead>
<tr class="header">
<th><p>Dynamics 365 user form</p></th>
<th><p>Active Directory user</p></th>
<th><p>Active Directory object tab</p></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>User name</p></td>
<td><p>User logon name</p></td>
<td><p>Account</p></td>
</tr>
<tr class="even">
<td><p>First name</p></td>
<td><p>First name</p></td>
<td><p>General</p></td>
</tr>
<tr class="odd">
<td><p>Last name</p></td>
<td><p>Last name</p></td>
<td><p>General</p></td>
</tr>
<tr class="even">
<td><p>Main Phone</p></td>
<td><p>Telephone number</p></td>
<td><p>General</p></td>
</tr>
<tr class="odd">
<td><p>Primary Email</p></td>
<td><p>Email</p></td>
<td><p>General</p></td>
</tr>
<tr class="even">
<td><p>*Address</p></td>
<td><p>City</p></td>
<td><p>Address</p></td>
</tr>
<tr class="odd">
<td><p>*Address</p></td>
<td><p>State/province</p></td>
<td><p>Address</p></td>
</tr>
<tr class="even">
<td><p>Home phone</p></td>
<td><p>Home</p></td>
<td><p>Telephones</p></td>
</tr>
</tbody>
</table>

* The Dynamics 365 Address field is comprised of the values from the City and State/province fields in Active Directory.


### See also  
 [Assigning Admin Roles](https://go.microsoft.com/fwlink/p/?LinkId=255444)   
 [Add users to Office 365 for business](https://support.office.com/article/Add-users-to-Office-365-for-business-435ccec3-09dd-4587-9ebd-2f3cad6bc2bc?ui=en-US&rs=en-US&ad=US)   
 [Security roles and privileges](../admin/security-roles-privileges.md)   



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]