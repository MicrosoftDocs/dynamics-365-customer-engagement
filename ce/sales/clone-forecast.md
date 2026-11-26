---
title: "Clone a forecast in Dynamics 365 Sales"
description: "Learn how to clone a forecast in Dynamics 365 Sales."
ms.date: 05/29/2026
ms.topic: how-to
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ai-usage: ai-assisted
---
# Clone a forecast 

Clone a forecast to reuse a working configuration without starting from scratch. Common use cases include:

- Setting up the next quarter's forecast with the same columns, hierarchy, and permissions as this quarter
- Creating a "what-if" version with different quotas to model scenarios
- Testing configuration changes without affecting your active forecast

After cloning, you can edit the forecast name, hierarchy, columns, quotas, permissions, or any other setting. The clone is completely independent from the original — changes to one don't affect the other. Once you're satisfied with the changes, activate the cloned forecast.

## To clone a forecast

1. Sign in to the Sales Hub app.

2. In the site map, select **Change area** ![Change area.](media/change-area-icon.png), and then select **App Settings**.

3. Under **Performance management**, select **Forecast configuration**.    
    The forecast configuration page opens.

4. On the forecast that you want to clone, select **More options** ![More options.](media/more-commands-icon.png), and then select **Clone**.   
    :::image type="Clone the forecast" source="media/forecast-select-clone.png" alt-text="Clone the forecast":::  

5. In the message that appears, select **OK**.

    :::image type="Select OK in the confirmation message" source="media/forecast-clone-confirmation-message.png" alt-text="Select OK in the confirmation message":::    

    The clone opens in draft mode (not yet active). You can now customize it before activation.

6. Edit the forecast to meet your needs, and then activate it.


## Next steps after cloning

After the clone opens in edit mode, you can:

- [Configure columns and layout](choose-layout-and-columns-forecast.md) — adjust the forecast structure
- [Update hierarchy or permissions](provide-permissions-forecast.md) — change who can view or adjust
- [Upload data and activate](activate-upload-simple-columns-data-forecast.md) — add quota data and make the forecast live

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)]

## Related information

[Configure forecasts in your organization](configure-forecast.md)   



[!INCLUDE[footer-include](../includes/footer-banner.md)]
