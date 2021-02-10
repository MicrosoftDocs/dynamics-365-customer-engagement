---
title: "View and understand the status of prediction column in a forecast | MicrosoftDocs"
description: "View and understand the status of prediction column in a forecast."
ms.date: 10/26/2020
ms.service: crm-online
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
---

# View prediction model status 

You can view the details of the prediction model, such as last predicted date and errors in a forecast. After a model is generated, an icon is displayed corresponding to the **Prediction** column in the [layout configuration step](https://docs.microsoft.com/dynamics365/sales-enterprise/choose-layout-and-columns-forecast) of a forecast. Based on the icon, you can determine whether the model was successful.

>[!NOTE]
>After you configure and publish a forecast with a prediction column for the first time, the column takes about two hours to display the data. 

## On successful prediction

When the prediction succeeds, an information icon is displayed corresponding to the **Prediction** column. Select the icon to see a side pane with the date of the last prediction.

> [!div class="mx-imgBorder"]
> ![Successful prediction model](media/predictive-forecasting-successful-model-creation.png "Successful prediction model")

## On erroneous prediction

When the prediction fails, an alert icon is displayed corresponding to the **Prediction** column. Select the icon to see a side pane with information about errors, warnings, and the last prediction date. Based on this information, you can take necessary steps to resolve the issues and regenerate the model.

> [!div class="mx-imgBorder"]
> ![Erroneous prediction model](media/predictive-forecasting-erroneous-model-creation.png "Erroneous prediction model")

### See also

[Premium forecasting](configure-premium-forecasting.md)
