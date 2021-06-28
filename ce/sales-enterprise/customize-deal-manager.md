---
title: "Customize deal manager workspace - Sales Enterprise | MicrosoftDocs"
description: "Customize the grid, side panel, and charts displayed in the deal manager."
ms.date: 06/30/2021
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
---

# Customize deal manager (Preview)

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
> A preview is a feature that is not complete, but is made available to you before general availability so you can evaluate the preview and provide feedback to Microsoft. Previews may have restricted functionality and may employ reduced or different privacy, security, or compliance commitments than a commercial version. As such, previews are not intended for production use, which means they are not meant for "live" Customer Data, Personal Data, or other data that is subject to heightened compliance requirements. Use of such data is at your sole risk and it's your sole responsibility to notify your end users about not including personal or sensitive information with their use of previews, as appropriate. We don't provide support for previews and Microsoft Dynamics 365 Technical Support won't be able to help you with issues or questions. This preview, and any one-off support Microsoft may elect to provide, is provided "as-is," "with all faults," "as available," and without warranty.

The deal manager workspace is highly customizable. As an administrator, you can customize the workspace to suit your organization's needs. You can customize the following objects in the deal manager:
- Editable grid
- Side panel
- Charts

## Customize the editable grid in deal manager


## Customize the side panel

## Customize the charts

The deal manager charts help sellers visualize their pipeline better. As an administrator, you can customize various elements in the chart such as, the data on x and y-axis, size of the bubble, sort order, and tool tips.  

**To customize the bubble chart:**

1. In the Sales Hub app, select the **Change area** icon
    ![Icon to change the work area](media/change-area-icon.png "Icon to change the work area")
    in the lower-left corner and then select **App Settings**. 
1. Under **General Settings**, select **Deal manager (preview)**.
1. In the **Manage charts** section, edit the **Deal tracker** chart. 
1. Customize the following elements:
    - **Horizontal (x) axis**
      Select any field of type *DateTime*. For example, you can choose to plot the chart based on delivered date instead of closed date.  
    - **Vertical (y) axis**
      Select any *numerical* field to plot on the vertical axis.   
    - **Segment by**
        Select how you want distinguish the bubbles using different color codes. For example, select **Pipeline Phase** to distinguish the bubbles based on the different phases of the pipeline such as identify, qualify, propose, and so on.   
    - **Size**
        Select a *numerical* field to indicate the size of the bubble.   
    - **Sort legend**
    - Not sure what this is.
  
        
    - **Tooltips**
        Select the details that you want to see as tooltips when you hover each  bubble. You can also remove the existing fields shown in the tooltip. 