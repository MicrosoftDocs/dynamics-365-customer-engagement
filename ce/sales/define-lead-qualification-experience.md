---
title: Define lead qualification experience in Dynamics 365 Sales
description: Give your salespeople the flexibility to choose which records to create—account, contact, or opportunity—when a lead is qualified.
ms.date: 08/06/2024
ms.topic: how-to
ms.custom: bap-template
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
searchScope: 
  - D365-App-msdynce_saleshub
  - D365-App-msdynce_salespro
  - D365-Entity-lead
  - D365-UI-*
  - Customer Engagement
  - Dynamics 365
  - Sales
---
# Define the lead qualification experience  

Give your salespeople the flexibility to choose which records to create&mdash;account, contact, or opportunity&mdash;when a lead is qualified.

## License and role requirements

| Requirement type | You must have |
|:-----------------|:--------------|
| **License** | Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise, or Dynamics 365 Sales Professional <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator <br> More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

## Define the experience using Sales Hub app

1. In the Sales Hub app, select the Change area icon :::image type="icon" source="media/change-area-icon.png" border="false"::: at the bottom of the site map, and then select **App Settings**.
2. Under **General Settings**, select **Lead + Opportunity management** > **Lead Qualification**.
3. Turn on **Auto-create records for newly qualified leads** to automatically create account, contact, and opportunity records when a lead is qualified. Turn the setting off if you want salespeople to choose which records to create when a lead is qualified. For information about the fields that are automatically mapped from the lead to other entities, see [Field mappings to other entities](#field-mappings-to-other-entities).

## Define the experience using legacy web client

If you aren't using the Sales Hub app, you can define the lead qualification experience by using the legacy web client.

1. In your app, select the **Settings** icon, and then select **Advanced Settings**.

   :::image type="content" source="media/advanced-settings-option.png" alt-text="Screenshot of Advanced Settings option on the Settings menu":::

   The **Business Management** page opens.
2. Select **Settings** > **Administration** > **System Settings**.
3. Select the **Sales** tab.
4. Under **Qualify lead experience**, set **Create Account, Contact, and Opportunity records by default upon qualifying a lead** to **No** to allow salespeople to choose which records to create when a lead is qualified. Set it to **Yes** to automatically create account, contact, and opportunity records when a lead is qualified.

## Field mappings to other entities

When a lead is qualified, values of some fields from leads are automatically mapped to the corresponding fields in accounts, contacts, and opportunities. To know why you can't delete out-of-the-box field mappings and apply custom field mappings for lead qualification, see [this FAQ](faq-lead.md#lead-qualification-custom-field-mappings).

**Fields mapped to opportunity**

| Field name in lead | Logical name in lead | Field name in opportunity | Logical name in opportunity |
|--------------------|----------------------|---------------------------|-----------------------------|
| Topic              | subject              | Topic                     | name                        |
| Contact            | parentcontactid      | Contact                   | parentcontactid             |
| Account            | parentaccountid      | Account                   | parentaccountid             |

**Fields mapped to account**

| Field name in lead | Logical name in lead     | Field name in account       | Logical name in account     |
|--------------------|--------------------------|-----------------------------|-----------------------------|
| Company            | companyname              | Account name                | name                        |
| Website            | websiteurl               | Website                     | websiteurl                  |
| Business Phone     | telephone1               | Phone                       | address1_telephone1         |
| Street 1           | address1_line1           | Address 1: Street 1         | address1_line1              |
| Street 2           | address1_line2           | Address 1: Street 2         | address1_line2              |
| Street 3           | address1_line3           | Address 1: Street 3         | address1_line3              |
| City               | address1_city            | Address 1: City             | address1_city               |
| State/Province     | address1_stateorprovince | Address 1: State/Province   | address1_stateorprovince    |
| Zip/Postal Code    | address1_postalcode      | Address 1: ZIP/Postal Code  | address1_postalcode         |
| Country/Region     | address1_country         | Address 1: Country/Region   | address1_country            |

**Fields mapped to contact**

| Field name in lead | Logical name in lead     | Field name in contact       | Logical name in contact      |
|--------------------|--------------------------|-----------------------------|------------------------------|
| First name         | firstname                | First name                  | firstname                    |
| Last name          | lastname                 | Last name                   | lastname                     |
| Job title          | jobtitle                 | Job title                   | jobtitle                     |
| Business Phone     | telephone1               | Phone                       | managerphone                 |
| Mobile phone       | mobilephone              | Mobile phone                | mobilephone                  |
| Email              | emailaddress1            | Email                       | emailaddress1                |
| Street 1           | address1_line1           | Address 1: Street 1         | address1_line1               |
| Street 2           | address1_line2           | Address 1: Street 2         | address1_line2               |
| Street 3           | address1_line3           | Address 1: Street 3         | address1_line3               |
| City               | address1_city            | Address 1: City             | address1_city                |
| State/Province     | address1_stateorprovince | Address 1: State/Province   | address1_stateorprovince     |
| ZIP/Postal Code    | address1_postalcode      | Address 1: ZIP/Postal Code  | address1_postalcode          |
| Country/Region     | address1_country         | Address 1: Country/Region   | address1_country             |

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)] 

## Related information
[Qualify or convert leads](qualify-lead-convert-opportunity-sales.md)  
[Create or edit leads](create-edit-lead-sales.md)  
[Troubleshoot issues with lead qualification](/troubleshoot/dynamics-365/sales/troubleshoot-lead-qualification-issues-for-system-admin)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
