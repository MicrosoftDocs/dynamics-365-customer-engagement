---
title: "Understand the lead distributions in assignment rules"
description: "A tutorial on how the leads are automatically distributed to sellers in assignment rules."
ms.date: 11/26/2021
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
---

# Understand lead distributions in assignment rules

In Dynamics 365 Sales, assignment rules define how leads are automatically distributed to sellers. When a lead is created and meets certain conditions that are defined in assignment rules, the lead is automatically assigned to the right seller. The automated process saves time and optimizes the workload across your sales team.

The following factors help to determine how leads are assigned:   
-	How many active leads are already assigned to sellers
-	When a seller was last assigned a lead

## License and role requirements
|  | |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise  <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security Role** | System Administrator or Sequence Manager <br>  See [Predefined security roles for Sales](security-roles-for-sales.md)|
|||


## Basic lead distribution

There are two types of basic algorithms for lead distribution: 
-	[Round robin](#round-robin)
-	[Load balancing](#load-balancing) 

### Round robin

In the round&mdash;robin-based assignment, the system looks at all the matched sellers of the lead and assigns it to the one who was assigned a lead least recently. This includes lead assignments from other sources such as manual assignment or via a plugin.    

Let’s take an example to understand the distribution criteria:  
A lead comes into the system, and application identifies the following potential sellers that can work on the lead, based on the selection criteria defined in the assignment rules. 

| Seller | Last assigned a lead |
|--------|----------------------|
| Seller 1 | 12 July 2021 11:00 |
| Seller 2 | 12 July 2021 10:00 |
| Seller 3 | 12 July 2021 12:00 |

The algorithm looks at the sellers’ last assigned lead times and identifies that **Seller 2** was assigned a lead least recently and thus the lead is assigned to **Seller 2**. If the routing took place on 12 July 2021 at 13:30, the algorithm updates the **Seller 2** last assigned lead time to the same value.

Now, taking this process through one more cycle, and another lead comes into the system. But only **Seller 2** and **Seller 3** have the required attributes to work on the lead. So, the algorithm again looks at the following table and observe how the last assigned lead has been updated for **Seller 2**.

| Seller | Last assigned a lead |
|--------|----------------------|
| Seller 2 | 12 July 2021 13:30 |
| Seller 3 | 12 July 2021 12:00 |

The algorithm finds that **Seller 3** was assigned the lead least recently, and thus the lead is assigned to seller and update seller's last assigned lead time to the time of routing. 

### Load balancing

In the load balancing-based assignment, the system looks at all the matched sellers of the lead and assigns it to the seller with maximum available capacity. This method helps to ensure that all salespeople are equally busy and minimizes uneven workloads.

Let’s take an example for understanding the distribution:
A lead comes into the system, and application identifies the following potential sellers that can work on the lead, based on the selection criteria defined in the assignment rules.

| Seller | Available Capacity |
|--------|--------------------|
| Seller 1 | 10 |
| Seller 2 | 12 |
| Seller 3 | 15 |

Since, **Seller 3** has maximum available capacity of all the eligible sellers, the lead will be assigned to **Seller 3**, and their available capacity will be updated.

| Seller | Available Capacity |
|--------|--------------------|
| Seller 1 | 10 |
| Seller 2 | 12 |
| Seller 3 | 14 |

Now, to understand this better, consider the following series of events and assume that Sellers 1 to 3 are all possible owners for the incoming leads.

- **Event 1**: Two new leads come into the system, which matches the rule. 
    Both leads will be assigned to **Seller 3** and table would look like the following: 
    
    | Seller | Available Capacity |
    |--------|--------------------|
    | Seller 1 | 10 |
    | Seller 2 | 12 |
    | Seller 3 | 12 |

- **Event 2**: One more lead comes into the system.
    The lead would be assigned to either **Seller 2** or **Seller 3** since they both have equal available capacity. Say it's assigned to Seller 2, then the table would be updated to: 
    
    | Seller | Available Capacity |
    |--------|--------------------|
    | Seller 1 | 10 |
    | Seller 2 | 11 |
    | Seller 3 | 12 |

- **Event 3**: **Seller 1** closes three active leads and a new matching lead comes for routing. 
    For the incoming lead, the available capacity would look like the following and thus it will be assigned to **Seller 1**.
    
    | Seller | Available Capacity |
    |--------|--------------------|
    | Seller 1 | 13 |
    | Seller 2 | 11 |
    | Seller 3 | 12 |

## Additional lead distribution criteria

Before moving ahead, from the earlier section about round robin and load balancing, the sellers are sorted according to their respective priorities, which help us to select the top candidate for the lead.

Let us consider the following table as an example:

| Seller | Last assigned a lead | Available capacity |
|--------|----------------------|--------------------|
| Seller 1 | 12 July 2021 11:00 | 10 |
| Seller 2 | 12 July 2021 10:00 | 12 |
| Seller 3 | 12 July 2021 12:00 | 15 |

In the round robin distribution criteria, the priority of sellers would be as follows:

| Seller | Last assigned a lead |
|--------|----------------------|
| Seller 2 | 12 July 2021 10:00 |
| Seller 1 | 12 July 2021 11:00 |
| Seller 3 | 12 July 2021 12:00 |

In the load balancing distribution criteria, the priority of sellers would be as follows: 

| Seller | Available capacity |
|--------|--------------------|
| Seller 3 | 15 |
| Seller 2 | 12 |
| Seller 1 | 10 |

Now, considering seller capacity and availability, let’s introduce additional processing of to better prioritize the sellers according to the requirements.
Currently, there are two additional processes available for further controlling the prioritization.    
- [Consider seller capacity](#consider-seller-capacity)
- [Consider seller availability](#consider-seller-availability)

### Consider seller capacity

By selecting this option, the leads are routed only to those sellers who have available capacity to work on the leads&mdash;positive available capacity. If none of the eligible sellers have available capacity, then the lead will be marked as unassigned.

For more information on managing seller's capacity, see [Set capacity for sellers](manage-sales-teams.md#set-capacity-for-sellers)

Let’s take an example for round robin. Consider a lead comes with the following matched sellers with the following last assigned lead times and available capacity.

| Seller | Last assigned a lead | Available capacity |
|--------|----------------------|--------------------|
| Seller 1 | 12 July 2021 11:00 | -2 |
| Seller 2 | 12 July 2021 10:00 | 0 |
| Seller 3 | 12 July 2021 12:00 | 4 |
| Seller 4 | 12 July 2021 13:00 | 1 |

For round&mdash;robin distribution, the priority is defined as following for the sellers:

| Seller | Last assigned a lead | Available capacity |
|--------|----------------------|--------------------|
| Seller 2 | 12 July 2021 10:00 | 0 |
| Seller 1 | 12 July 2021 11:00 | -2 |
| Seller 3 | 12 July 2021 12:00 | 4 |
| Seller 4 | 12 July 2021 13:00 | 1 | 

Since, **Seller 1** and **Seller 2** have negative available capacity, they will not be considered as eligible owners, and the table will reduce to:

| Seller | Last assigned a lead | Available capacity |
|--------|----------------------|--------------------|
| Seller 3 | 12 July 2021 12:00 | 4 |
| Seller 4 | 12 July 2021 13:00 | 1 | 

The lead will be assigned to **Seller 3**.

When you select the **Consider seller capacity** option, it removes the sellers with negative or zero available capacity from the list of owners at the time of routing.

### Consider seller availability  

By selecting this option, the system considers work schedule of sellers that is defined in the Sales Accelerator and filter sellers based on their availability to work on the leads.    
The algorithm analyzes sellers’ availability in the order of the lead assignment priority (Load Balancing or Round Robin) and assign lead to a seller who is currently available.

If the matched sellers are currently unavailable, the leads are assigned to sellers who are available within the next 24 hours of the time of routing. If no sellers are available within the next 24 hours, then the leads are assigned to sellers wo are available within the next 48 hours, and so on, until 120 hours. Otherwise, the leads are marked as unassigned.    
The sellers are divided in to six buckets based on their availability. The buckets are viewed in top to bottom order to find the first non-empty bucket and then distribute the lead among the sellers in the bucket based on round robin (or load balancing, supported only in the first bucket).   

>[!div class="mx-imgBorder"]
>![Six buckets that the sellers are divided into based on the availability.](media/sa-ar-lead-distribution-buckets.png "Six buckets that the sellers are divided into based on the availability")   

To know more on how sellers update their personal work schedule in sales accelerator, which is also used by assignment rules, see [Configure your work availability](personalize-sales-accelerator.md#configure-your-work-availability)

Let's take some examples to walk through this:
We'll use the following notation for availability time at the time of routing:
-	0D - Currently Available
-	1D - Earliest Available within 24 hours
-	2D - Earliest Available within 24 – 48 hours
-	3D - Earliest Available within 48 – 72 hours
-	4D - Earliest Available within 72 – 96 hours
-	5D - Earliest Available within 96 – 120 hours

**Example 1**: We have matched Sellers 1 – 5 and the primary distribution criteria is round robin.

| Sellers | Availability | Last assigned a lead |
|---------|--------------|----------------------|
| Seller 1 | 1D	| 12 July 2021 11:00 |
| Seller 2 | 1D | 12 July 2021 10:00 |
| Seller 3 | 0D | 12 July 2021 12:00 |
| Seller 4 | 2D | 12 July 2021 13:00 |
| Seller 5 | 0D | 12 July 2021 10:30 |

Since we have two sellers who are available currently, the lead will be distributed between them based on round robin criteria.

| Sellers | Availability | Last assigned a lead |
|---------|--------------|----------------------|
| Seller 3 | 0D | 12 July 2021 12:00 |
| Seller 5 | 0D | 12 July 2021 10:30 |

When a lead is created, it will be assigned to **Seller 5**. Further, the incoming leads for this rule will be assigned to **Seller 3** and **Seller 5** in a round robin distribution, until the availability of the matched sellers change. 

**Example 2**: We have matched Sellers 1 to 5 and the primary distribution criteria is load balancing.

| Sellers | Availability | Available capacity |
|---------|--------------|----------------------|
| Seller 1 | 1D	| 14 |
| Seller 2 | 1D | 20 |
| Seller 3 | 0D | 5 |
| Seller 4 | 2D | 10 |
| Seller 5 | 0D | 2 |

Since, Sellers 3 and 5 are currently available, the primary distribution criteria is load balancing, the lead would be assigned to **Seller 3**.

**Example 3**: We have matched Sellers 1 to 5 and the primary distribution criteria is load balancing and consider seller capacity has been selected.

| Sellers | Availability | Available capacity |
|---------|--------------|--------------------|
| Seller 1 | 1D	| 14 |
| Seller 2 | 1D | 20 |
| Seller 3 | 0D | -1 |
| Seller 4 | 2D | 10 |
| Seller 5 | 0D | 0 |

Since, consider seller capacity has been selected Sellers 3 and 5 are not eligible for routing.

| Sellers | Availability | Available capacity |
|---------|--------------|--------------------|
| Seller 1 | 1D	| 14 |
| Seller 2 | 1D | 20 |
| Seller 4 | 2D | 10 |

The earliest availability bucket is 1D, thus, Sellers 1 and 2 are considered.

| Sellers | Availability | Available capacity |
|---------|--------------|--------------------|
| Seller 1 | 1D	| 14 |
| Seller 2 | 1D | 20 |

Since, the sellers are not currently available, this distribution will happen according to Round Robin for these sellers.

>[!NOTE]
>Primary selected criterion is load balancing.

So, let's assume the following last assigned times:

| Sellers | Availability | Available capacity |  Last assigned a lead |
|---------|--------------|--------------------|-----------------------|
| Seller 1 | 1D	| 14 | 12 July 2021 10:00 |
| Seller 2 | 1D | 20 | 12 July 2021 11:00 |

The lead will be assigned to **Seller 1**. Further, leads for this rule and same seller match will be assigned to **Seller 2** and **Seller 1**, in round robin criteria.

### See also

[Create and activate an assignment rule ](create-and-activate-assignment-rule.md)

