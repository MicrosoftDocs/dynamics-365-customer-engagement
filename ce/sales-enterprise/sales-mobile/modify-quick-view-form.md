---
title: Modify quick view forms for the Dynamics 365 Sales mobile app
description: Learn to modify quick view forms for the Dynamics 365 Sales mobile app.
ms.date: 03/02/2021
ms.topic: article
ms.service: dynamics-365-sales
author: sbmjais
ms.author: shjais
manager: shujoshi
---

# Modify quick view forms

[!INCLUDE [cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

The Dynamics 365 Sales mobile app uses the quick view form to display table details. This is a lightweight form that doesn't include all attributes of the table. More information: [Create a quick view form](https://docs.microsoft.com/powerapps/maker/model-driven-apps/create-edit-quick-view-forms)

If you've created multiple quick view forms, the mobile app uses the first form in the quick view form order. In the following example, three quick view forms were created for the **Contacts** table with the form order as shown.

|Form order|Form name|
|----------|---------|
|1|Contact quick view form one|
|2|Contact quick view form two|
|3|Contact quick view form three|
|||

In this example, the mobile app displays information based on the fields defined in **Contact quick view form one**.

If you want to change the fields that the mobile app displays, modify the first quick view form in the form order. If you want a different quick view form to be used for displaying information, move that form to the top of the form order. More information: [Set the form order](https://docs.microsoft.com/powerapps/maker/model-driven-apps/control-access-forms#set-the-form-order)

### See also

[Use the Dynamics 365 Sales mobile app](use-sales-mobile-app.md)    
[Learn the basics](learn-basics-mobile-app.md)
