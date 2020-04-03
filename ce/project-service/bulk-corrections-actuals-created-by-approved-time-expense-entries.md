---
# required metadata

title: Bulk corrections of actuals created by approved time and expense entries
description: This topic explains how an administrator can make single or bulk corrections to previously approved time or expense entries if the billing is not complete.   
author: rumant
manager: AnnBe
ms.date: 04/02/2020
ms.topic: article
ms.prod: 
ms.service: dynamics-ax-applications
ms.technology: 

# optional metadata

# ms.search.form: 
# ROBOTS: 
audience: Application User
# ms.devlang: 
ms.reviewer: kfend
ms.search.scope: Core, Operations
# ms.tgt_pltfrm: 
ms.custom: 
ms.assetid: 
ms.search.region: Global
ms.search.industry: Service industries
ms.author: v-radsh
ms.dyn365.ops.version: 7.0
ms.search.validFrom: 2019-01-15

---

# Bulk corrections of actuals created by approved time and expense entries

Occasionally a time or expense entry may be entered incorrectly. For example, a consultant might select the wrong date when creating a time entry or they might transpose the numbers when entering an expense. If a consultant can’t make the updates to the submitted entries, an administrator can directly correct the entry for a project.

To complete the procedures in this topic, you will need Administrator permissions.

## Correct approved time entries     

Complete the following steps to correct single or multiple time entries for a project.

1. In the **Sales** area, select **Transactions**, and then select **Approved Time**. 

2. In the **Approved Time** list, locate and select one or more approved time entries to correct. You can use the filter to locate related entries. For example, you might filter on a Project ID, and select all approved time entries with that Project ID.

3. Select **Correct entries**. A new correction journal is automatically created, with the assigned type **Time correction**. The entries you selected are added to the journal. 

4. On the **New Journal** page, enter a **Description** for your correction journal, and then select the **Time Entry Corrections** tab.  
5. In the **New Values for Time Entries** section, update the fields with the correct information as necessary. For example, you can change the assigned project or the bookable resource.

6. Select **Preview**. In the dialog box, select **OK**. On the **Journal lines** tab, you can view a list of the original actuals that are related to the selected time entries that have been reversed and the corrected corresponding lines that have been created. If additional corrections need to be made, repeat steps 5 and 6. 

> [!NOTE]
> All the corrected actuals will have the same values that you selected in the **New values for Time Entries** section.

7. If the corrections appear as expected, select **Confirm**. In the dialog box, select **OK**.

8. Return to the **Sales** area, select **Projects**, and then open the project for which you just updated the time entries. 

9. On the **Projects** page, on the **Actuals** tab, view the changes that you made. 

> [!NOTE]
> If the **Actuals** tab is not visible, select **Related** > **Actuals**.  

10. In the **Actual Associated View** list, you can see that the original time entries that have been reversed are still listed, as are the corresponding corrected time entries. 

For example, in the following graphic, there are two line items with a quantity of 8.00 that have debits listed in the Amount column. Additionally, there are two line items with a quantity of -8.00 that show credited amounts in the Amount column. These corrections bring the quantity to zero.

![Actual associated view list](https://github.com/MicrosoftDocs/dynamics-365-customer-engagement-pr/blob/bulk-corrections-actuals-created-by-approved-time-expense-entries.md/time-actuals.png)
 
## Correct approved expense entries

Complete the following steps to correct one or more expense entries. 

1. In the **Sales** area, in the left navigation pane, under **Transactions**, select **Approved Expenses**.

2. In the **Approved Expenses** list, select the project that you want to correct, and then select **Correct entries**. A new correction journal will be created automatically with the assigned type of **Expense correction**. 

3. On the **New Journal** page, enter a **Description** for the correction, and on the **Expense Correction** tab, in the **New Values for Expenses** section, select the data fields that you want to correct for the selected expense lines. For example, you can assign the expense to another **Project**, or correct the **Expense Category**, **Expense Date**, or **Bookable Resource**.

4. Select **Preview**. In the dialog box, select **OK**. 

5. Verify the corrections on the **Journal lines** tab. You can view a list of the original actuals that are related to the selected expense entries that have been reversed and the corrected corresponding lines that have been created.

6. If the corrected values are as expected, select **Confirm**. In the dialog box, select **OK.** If the values are not showing as expected, select **Cancel** to return to the **Approved Expenses** list. Repeat steps 2 through 5. 

> [!NOTE]
> The corrected actuals will have the same values that you selected in the **New values for Expenses** section.

7. After you confirm the correction journal, navigate back to the project or projects that you updated, to view your changes.  

8. In the project page, on the **Actuals** tab, review the **Actual Associated View**. The original entries and the corrected entries are listed. The following graphic shows original expense entry amounts and the corresponding corrected expense entry amounts. 

![Expense_actuals](https://user-images.githubusercontent.com/60806505/77122219-4cd52900-69fa-11ea-8349-ccd2ffebf640.png)
