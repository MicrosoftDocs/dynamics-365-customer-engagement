---
title: Segment your insights
description: Fill in.
keywords: dynamics 365; customer insights
Applies_to: Dynamics 365 for Customer Insights
author: jimholtz
ms.author: jimholtz
manager: brycho
ms.date: 07/03/2017
ms.topic: get-started-article
ms.service: customer-insights 
ms.assetid: 2ed4506a-68d8-45db-bc9c-59ec7d82b093
---
Segment your insights
==========================
[!include[pre release disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

##Create a static segment

1.  Open your Customer Insights Customer 360 application.

2.  Select **Show Menu** ![Show Menu](../media/ShowMenu75.png "Show Menu"). 

3.  Select **All Options** > **Segmentation**.

    ![Select Segmentation](../media/SegmentationNewMenu75.png "Select Segmentation")

4.  Under Static select **Create**.

5.  Fill in the values and select **Save**.

 ![New Static Segment](../media/SegmentNewStatic75.png "New Static Segment")

    **Properties**
    |**Item**|**Description**|
    | ----------- | ---------- |
    | Segment Name | The name of the static segment. |
    | Description | A description of the segment. |
    | Audience type | The profile to segment on.  |

    **List members**

    Choose the members to be included in the segment. For example, the customers who requested to not be contacted.

    ![New Static Segment](../media/SegmentDoNotCallMod650.png "New Static Segment")


 ##Create a dynamic segment

1.  From the Segmentation Dashboard, select **Add** > **Dynamic Segment**.

    ![Add Dynamic Segment](../media/SegmentAddDynamic75.png "Add Dynamic Segment"). 

3.  Fill in the values and select **Save**.

 ![New Dynamic Segment](../media/SegmentNewDynamic650.png "New Dynamic Segment")

    **Properties**
    |**Item**|**Description**|
    | ----------- | ---------- |
    | Segment Name | The name of the dynamic segment. |
    | Description | A description of the segment. |
    | Audience type | The profile to segment on.  |
    | Status |  |

    **Flow**: Use this to visually build your segment.

    **Designer**: Choose this for an interactive approach more suited to advanced users.

    **Query**: Use this to manually enter a query.

###Example: Using Flow to define a dynamic segment

The following are settings for a dynamic segment to find customers using security products with low satisfaction.

![Example Dynamic Segment](../media/SegmentDynamicSocial720.png "Example Dynamic Segment")

A group consists of profiles joined together by set operations such as union, intersect, and exclude. 

Note that all profiles included with the group end with the node selected in Audience type; in this case, Customer. 

![Audience Type and Group](../media/SegmentGroupAndAudienceType720.png "Audience Type and Group")

Let's say you want to segment a group that has the following attributes:
- Customers who use security products
- Security product 5567 is not included
- Customer satisfaction is < 60

Here are the steps:

1. On the Properties page for Dynamic Segment, select **+ Add Group**.

2. In the group, select **Product**, enter "Security" for Product.Category, and then click **Add** (+).

    ![Select Security for Product.Category](../media/SegmentProductCategorySec75.png)

3. For Product.ProductID, enter "5567", click **Add** (+), and then click **And**.

    ![Add Product.ProductId](../media/SegmentProductID75.png)

4. For Customer.CustomerSatisfaction, select **<**, enter "60", the click **Add** (+).

    ![Add Customer.CustomerSatisfaction](../media/SegmentCustomerSat75.png)

5. Select **OK** to save these group settings.

The group created from these steps consists of people using security products (excluding 5567) whose satisfaction is less than 60 out of 100.

Select the **Query** tab to see the group settings defined as a query.

![Query for the segment](../media/SegmentQuery650.png "Query for the segment")

##Create a compound segment

1. From the Segmentation Dashboard, select **Add** > **Compound Segment**.

    ![Add Compound Segment](../media/SegmentAddCompound75.png "Add Compound Segment"). 

2. Fill in the values and select **Save**.

 ![New Compound Segment](../media/SegmentNewCompound75.png "New Compound Segment")

    **Properties**
    |**Item**|**Description**|
    | ----------- | ---------- |
    | Segment Name | The name of the compound segment. |
    | Description | A description of the segment. |
    | Status |  |

###Example: A compound segment for high value customers

The following steps show the creation of a compound segment of high credit card balance customers who should be sent a followup communication.

1. Select the dynamic segment of high balance customers.

    ![Select dynamic segment](../media/SegmentHighBalance75.png) 

2. Exclude the customers who do not want to be contacted.

    ![Exclude do not call](../media/SegmentExcludeDoNotCall720.png "Exclude do not call")

    There are four customers who will be excluded.

    ![Exclude customers](../media/SegmentFourDoNotCall75.png)

3. Select **Save** and the compound segment is added to the dashboard.

![Example dashboard with multiple segments](../media/SegmentDashboardExample720.png "Example dashboard with multiple segments")

##View your segment details

Select a segment in the dashboard to see member and trendline information.

![Segment member and trend information](../media/SegmentInfo720.png "Segment member and trend information")

### See also
[What is segmentation?](newfeatures.md#what-is-segmentation)