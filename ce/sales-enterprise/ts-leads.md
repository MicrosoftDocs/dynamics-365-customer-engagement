---
title: "Troubleshooting the Lead entity (Dynamics 365 Sales) | MicrosoftDocs"
description: "Learn how to troubleshoot issues with the Lead entity in Dynamics 365 Sales."
ms.date: 03/24/2020
ms.service:
  - "dynamics-365-sales"
ms.topic: article
author: shubhadaj
ms.author: shujoshi
manager: annbe
---

# Troubleshooting the Lead entity 

This article helps you troubleshoot and resolve issues related to the Lead entity.

<a name="lead_qualification"> </a>
## Lead qualification issues and resolution (sales people)

<a name="qualify_lead"> </a>
### How do I convert or qualify my leads?

You qualify a lead when you determine that the lead you've nurtured has a potential to turn into business. When you qualify a lead, it becomes an opportunity.

To qualify a lead, select **Qualify** on the command bar of the lead record.

> [!div class="mx-imgBorder"]  
> ![Qualify button on the Lead form](media/qualify-button-lead-form.png "Qualify button on the Lead form")

You can also qualify a lead from the list of leads. Go to **Sales** > **Leads**. Select the lead you want to qualify and on the command bar, select **Qualify**.

<a name="cant_qualify_lead"> </a>
### Issue: I can't qualify a lead.
There are multiple errors you could get while qualifying a lead. 
1.  [Duplicate warning – There might already be a match for this account or contact. If so, please select it.](#duplicate)
2.  [To move to the next stage, complete the required steps](#CompleteSteps)
3.  [Active stage is not on 'lead' entity](#NoActiveStage)
4.  [Access denied or Insufficient permissions](#AccessDenied)
5.  [The lead is closed. You cannot convert or qualify a lead that is already closed.](#LeadClosed)

The following sections describe each of these errors and how you can resolve them.

<a name="duplicate"> </a>
#### 1. Duplicate warning – There might already be a match for this account or contact. If so, please select it.

> [!div class="mx-imgBorder"]  
> ![Duplicate warning while qualifying a lead](media/duplicate-warning.png "Duplicate warning while qualifying a lead")


**Reason:**

When the lead is qualified to an opportunity, a corresponding account or contact is created. There might already be a match for this account or contact.

**Resolution:**

On the **Duplicate warning** dialog box, select the existing account or contact to avoid creating duplicates. To create a new record instead, select **Continue**.

> [!NOTE]
> When you qualify a lead through the Leads grid, the system creates an account or contact even though a duplicate record exists. By design, the rule that detects the duplicate records gets disabled. However, when you qualify a lead through the lead record form, the duplicate detection rule works. The rule prompts you with a warning to resolve the conflict if any duplicate records for account or contact are found.

<a name="CompleteSteps"> </a>
#### 2. To move to the next stage, complete the required steps

**Reason:** 

You haven't filled in data in all the business-required fields in the current stage of the process stage.

**Resolution:**

Fill in data in all the mandatory fields in the current stage, save the record, and then try qualifying the lead again.

<a name="NoActiveStage"> </a>
#### 3. Active stage is not on 'lead' entity

**Reason:**

The lead that you're trying to qualify isn't in the Active state. This might happen when an already qualified lead has been reactivated.

**Resolution:**

1. Open the lead record.
2. On the process stage, select the **Set Active** button.

    > [!div class="mx-imgBorder"]  
    > ![Set Active button in the Qualify stage of lead form](media/set-active-button-qualify-stage.png "Set Active button in the Qualify stage of lead form")

<a name="AccessDenied"> </a> 
#### 4. Access denied or Insufficient permissions

**Reason:**

You don't have sufficient permissions on the lead record. 

**Resolution:**

Ask your system administrator to grant you the necessary permissions.
If there's no error, and you're still not able to qualify a lead, contact the technical support.

<a name="LeadClosed"> </a>
#### 5. The lead is closed. You cannot convert or qualify a lead that is already closed.

**Reason:** 

You are trying to qualify or disqualify a lead that's closed. 

**Resolution:**

Make sure that the lead that you're trying to qualify or disqualify is open and not already qualified or disqualified. You can do this by selecting the My Open leads or Open Leads view.


<a name="lead_qualification_for_admins"> </a> 
## Lead qualification issues and resolution (for system administrators)

<a name="insufficientpermissions"> </a> 
### Issue: Insufficient permissions or Access denied error when a user is trying to qualify a lead

How you resolve this error depends on the following ownership scenarios for the lead records. 
-  [The lead is owned by the user trying to qualify it](#OwnedByUser)
-  [The lead that the user is trying to qualify is in their business unit](#BusinessUnit)
-  [The lead that the user is trying to qualify is in their organization](#Organization)

<a name="OwnedByUser"> </a>
**Scenario:** 
The lead is owned by the user trying to qualify it.

**Resolution:** 
1. Make sure you have a system administrator role or equivalent permissions.
2. Go to **Settings** > **Security Role**.
3. Open the security role of the user.
4. On the **Core Records** tab, assign **Create**, **Read**, **Append**, and **Append To** permissions to the Security Role at User level on the following entities:
    -  Account 
    -  Lead
    -  Contact
    -  Opportunity 

    ![Security role with access at User level](media/security-role-sales-person.png "Security role with access at User level")

5.    On the **Custom Entities** tab, assign Read access to any custom entity.
6.    On the **Customizations** tab, assign **Read** access to **Attribute Map**, **Customizations**, **Entity** and **Entity Map**.

<a name="BusinessUnit"> </a>
**Scenario:**
The lead that the user is trying to qualify is in their business unit.

**Resolution:**
1. Go to **Settings** > **Security Role**.
2. Open the security role of the user.
3. Assign **Create**, **Read**, **Append**, and **Append To** permissions to the user's Security Role at Business Unit level on the following entities:
    -  Account 
    -  Lead
    -  Contact
    -  Opportunity 

    ![Security role with access at Business Unit level](media/security-role-sales-person-bu-access.png "Security role with access at Business Unit level")

4. Assign **Read** access to any custom entity.
5. Assign **Read** access to **Attribute Map**, **Customizations**, **Entity** and **Entity Map**

<a name="Organization"> </a>
**Scenario:**
The lead that the user is trying to qualify is in their organization.

**Resolution:**
1. Go to **Settings** > **Security Role**.
2. Open the security role of the user.
3. Assign **Create**, **Read**, **Append**, and **Append To** permissions to the user's Security Role at Organization level on the following entities:
    -  Account 
    -  Lead
    -  Contact
    -  Opportunity 
 
    ![Security role with access at Organization level](media/security-role-sales-person-org-access.png "Security role with access at Organization level")

4. Assign Read access to any custom entity.
5. Assign Read access to **Attribute Map**, **Customizations**, **Entity** and **Entity Map**.

<a name="auto-generation-of-fields"> </a>
## Automatic generation of contact or company-related fields

When you select an existing account or contact at the time of creating a new lead, the fields related to the account or contact are automatically populated. 
- For the contact-related fields to be automatically populated, the default fields such as Name, Job title, business phone, Mobile phone, and Email must be empty.
- For the company-related fields to be automatically populated, the default fields such as Address, Website and Company Name must be empty.

<a name="account-contact-fields-not-populating"> </a>
### Issue: Account or contact-related fields aren't populating on the Lead form.

**Resolution:** 

Verify that the On-load script in the Lead form has reference to 'LeadManagement/Lead/Lead_main_system_library.js' web resource. This web resource contains the script that automatically populates fields. If you've  customized the Lead form and used a web resource other than the out-of-the-box web resource, then this feature won't work. Please contact your system administrator.

Even if you have a custom lead form, the automatic generation of fields works if the Lead form has reference to 'LeadManagement/Lead/Lead_main_system_library.js' web resource.


### See also

[Dynamics 365 Sales troubleshooting guide](troubleshooting.md)  