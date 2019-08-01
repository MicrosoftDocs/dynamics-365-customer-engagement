---
title: "Customize the business card scan control (Dynamics 365 for Sales) | MicrosoftDocs"
description: "Customize how the data from the scanned business cards maps to the fields in the Contact and Lead forms."
keywords: "business card, scan, scanner, lead, contact, populate, data, customize"
ms.date: 08/01/2019
ms.service:
  - "dynamics-365-sales"
ms.custom:
  - "dyn365-sales"
ms.topic: article
ms.assetid: 39954f18-c558-4b22-841a-7b12c9c948f2
author: shubhadaj
ms.author: shujoshi
manager: annbe
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
---

# Customizing the business card scanner control

[!INCLUDE[cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

Dynamics 365 for Sales comes with an out-of-the-box business card control that defines the mapping of what information from the business card goes in which fields of the Contact or Lead forms. If you have custom fields on your Contact or Lead form and you want the data from the business card to be populated in these fields, edit the default mappings of the business card control.


> [!IMPORTANT]
> - [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
> - [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]
> - This feature is available only in the EMEA and North America regions.

To edit the mappings,

1.  On the nav bar, select **Settings**, and then select **Advanced Settings**.

    The **Business Management** settings page opens.

2.  On the nav bar, select **Settings**, and then under **Customization**, select **Customizations**.

3.  Select **Customize the system**.

4.  In the Solution explorer, under **Components**, expand **Entities**, and
    then expand the Contact or Lead entity.

5.  Select **Forms**.

    ![Forms node of Contact entity in the Solution explorer](media/forms-node-in-contact-entity.png "Forms node of Contact entity in the Solution explorer")

6.  Open the form of type **Quick Create** or **Main**.

7.  Locate and select the **Business Card** field on the form, and in the
    **Edit** group, select **Change Properties**.

    ![Scan business card field in the Contact form](media/scan-business-card-field-in-contact-form.png "Scan business card field in the Contact form")

8.  In the **Field Properties** dialog box, on the **Control** tab, select the
    **AI Builder Business Card control**.

    ![Business card scanner control in the Field properties dialog box](media/business-card-scanner-control-field-properties-dialog-box.png "Business card scanner control in the Field properties dialog box")

9.  Select the property that you want to change the mapping for and select the Edit icon ![Edit icon](media/edit-icon.png "Edit icon") to change the value the field maps to.

10. When done, select **OK**.


### See also

[Scan business cards](scan-business-cards.md)