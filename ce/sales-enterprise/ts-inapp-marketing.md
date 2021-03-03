---
title: "Troubleshooting issues for in-app marketing (Dynamics 365 Sales) | MicrosoftDocs"
description: "Learn how to troubleshoot issues for in-app marketing in Dynamics 365 Sales."
ms.date: 03/03/2021
ms.service: dynamics-365-sales
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
---

# Troubleshooting in-app marketing

This article helps you troubleshoot and resolve issues related to in-app marketing.

## When I open Marketing List form, the Members view is not available     
**Reason**    
The error is occurring due to the customization of views for each sub grid in Marketing List form and the member list displays empty.      

**Resolution**    
To resolve the error, perform the following steps:
1.	Go to **Advanced Settings** > **Settings** > **Customizations** > **Customize the System**. 
2.	From the site map, open **Entities** > **Marketing List** > **Forms**.
3.	From the list of forms, select the **Marketing List** form. 
 
4.	On the **Marketing List** form, from the **Marketing List** site map, select **Members**.
 
5.	Select **Contacts** and then select **Change Properties**.

    The **Set Properties** window opens.
 
6.	In the **Additional Options** section, from the **View Selector** dropdown, choose **Show Selected Views** option.   

    The list of additional options is active.   

7.	Select the **My Active Contacts** view and from the **View Selector** dropdown, choose **Off**.
 
8.	In the **Name** section, clear the **Display the label on the Form** option.
 
9.	Click **OK**.    
10.	Repeat the steps 5 to 9 for Accounts and Leads.    
11.	Save and publish the form.    

## I’m unable to associate a campaign created from marketing list form with marketing list record in Unified Interface    

**Reason**    
The error is occurring due to the attribute **TmpRegardingObjectId** is removed from the **Campaign** form.

**Resolution**     
To resolve the error, perform the following steps:     
1.	Go to **Advanced Settings** > **Settings** > **Customizations** > **Customize the System**.      
2.	From the site map, open **Entities** > **Campaign** > **Forms**.
3.	From the list of forms, select the **Campaign** form. 
 
4.	From the **Field Explorer** pane displayed on the left of the page, add the field **TmpRegardingObjectId** to the form.
 
5.	Select the **TmpRegardingObjectId** field and then select **Change Properties**.    
    The Set Properties window opens.     
6.	In the **Label** section, clear the **Display label on the Form** option and from the **Visibility** section, clear **Visible by default**.    
 
7.	Save and publish the form.    

## Unable to find related account field for a member account using advanced find in Unified Interface     

**Reason**     
The error is occurring due to the display name of Contact or Account is changed in the application and the **Company Name (RELATED_TYPE)** picks related type from the changed display name.

**Resolution**   
In Unified Interface, the company name entity is available as **Company Name (Account)**. For example, if you rename the **Account** as **Organization**, then the entity is renamed as **Company Name (Organization)**.    

## Unable to send emails using email quick campaign distribution list

**Reason**    
The issue is occurring due to one of the following reasons:    
-	The users don’t have permissions to send emails on behalf of other users.   
-	The owner of the record (marketing list members) has not allowed other Dynamics 365 users to send emails on the owner’s behalf.   

**Resolution**   
To resolve the issue, perform one the following action depending on your reason:    
1.	The user who’s creating the quick campaign, the **Send Email as Another User** privilege must be assigned to at least one role assigned to user. More information: [Create a security role with team member's privilege inheritance](https://docs.microsoft.com/power-platform/admin/security-roles-privileges#create-a-security-role-with-team-members-privilege-inheritance).      

2.	For the owner of the record, the **Allow other Microsoft Dynamics 365 users to send email on your behalf** option must be enabled under **Personalization settings**.

## Unable to change the Form field in the email within the quick campaign wizard    

**Reason**
The issue is due to insufficient permission for **Send Email as another User** option for your role.    

**Resolution**    
To resolve this issue, provide sufficient permissions for **Send Email as another User** option to one of your roles.     

## Unable to see Email templates in the distribute dialog box   

**Reason**     
The UCI implementation of the email template selector dialog used during campaign distribution relies on certain access levels for different entities.     

**Resolution**     
To resolve the issue, the users required access to the system user records. Provide the access to system users through security role assignment in your Dynamics 365 organization. To learn more, see [Configure user security to resources in an environment](https://docs.microsoft.com/power-platform/admin/database-security).

## Campaign Activity Distribution related issues

### Campaign distribution process is stuck with status Pending or Failed   

**Reason**    
Campaign distribution process requires a workflow to run in the background. When the workflow is disabled, Campaign distribution will not complete and struck at **Pending** or **Failed** state.    

**Resolution**     
To resolve this issue, enable the workflow background process. Follow these steps:    
1.	Go to **Advanced Settings** > **Settings** > **System** > **System Jobs**. 
2.	Go to **ActivityPropagation** jobs and under **Process Sessions**, choose the job that matches the date and time in which the quick campaign was run.   

    >[!NOTE]
    > You can also check an approximate time in the quick campaign.   

3.	Verify that an error message is displayed under details section, stating that the async operation was skipped because the org is in **Disable Background Processing** mode. You must update the settings for your environment.    
4.	Go to admin center, select your instance, and then select **Admin Settings**.    

5.	Clear the **Disable background operations** option.    

6.	Save and exit.

### Why is my quick campaign failed and set to aborted   

**Reason**    
The issue is occurring due to the failure of a stack trace that are related the custom plugins in the workflow process.    

**Resolution**   
To resolve the issue, follow these steps:   
1.	Go to **Advanced Settings** > **Settings** > **System** > **System Jobs**.    
2.	Go to **ActivityPropagation** jobs and under **Process Sessions**, choose the job that matches the date and time in which the quick campaign was run.     

    >[!NOTE]
    > You can also check an approximate time in the quick campaign.    

    The system job contains information that includes a stack trace with the failure. Resolve the failure as mentioned in the stack trace failure.

### Quick campaign is executing unstoppable and generating thousands of failure records   

**Reason**    
When workflow fails to create campaign activities due to unknown condition, the workflow goes into an unstoppable loop and keeps create campaign activities which fail. You can observe that the number of failure count of quick campaign keeps increasing to much more than the total number of members in the targeting marketing list.     

**Resolution**    
To resolve the issue, deactivate the **ActivityPropagation** workflow and activate it again. Follow these steps:
1.	Go to **Advanced Settings** > **Settings** > **Customizations** > **Customize the System**.    
2.	From the site map, go to **Processes**.    
3.	Form the **View** selector, choose **All**.   
    All the available processes are displayed.    

4.	Select the **ActivityPropagation** workflow and then select **Deactivate**.    


5.	Wait for 24 hours and then reactivate the **ActivityPropagation** workflow.

### Campaign distribution doesn’t create activities on target entities   

**Reason**    
Target records (Account, Contact, and Lead) can have preferences for sending Marketing materials through campaign distribution for Emails, Phones, Fax, and Bulk Mail.
Campaign activities are created on member entity records of Marketing List only when below preferences are set to **Allow** or **Send**.
 
### Why campaign distribution is failing for some members    

**Reason**   
A campaign distribution happens with respect to the member in the marketing list. The member can be an account, contact, or lead. A campaign distribution can fail for members due to following reasons:    
-	The member from the marketing list does not have email address associated with it.   
-	The member from the marketing list has invalid email address associated with it.   
-	The member has configured the **Send Marketing Material** field in the member record as **Do not send**.  

**Resolution**    
To resolve the issue, review the reason for failure in the **Excluded members** grid for detailed reason and take necessary action.  

### See also

[Frequently asked questions](faqs-sales.md) </br>
[Dynamics 365 Sales troubleshooting guide](troubleshooting.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
