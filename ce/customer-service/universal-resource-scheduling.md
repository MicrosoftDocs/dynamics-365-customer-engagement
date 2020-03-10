---
title: Search resource availability and create bookings for requirement groups in Universal Resource Scheduling in Dynamics 365 Customer Service | Microsoft Docs
description: See how you can effectively search resource availability and create bookings for requirement groups in Universal Resource Scheduling in Customer Service Hub.
author: lerobbin
ms.author: lerobbin
manager: shujoshi
ms.date: 03/10/2020
ms.topic: article
ms.service: 
  - dynamics-365-customerservice
ms.custom: 
  - dyn365-customerservice
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
---

# Search resource availability and create bookings for requirement groups

Use the Search Resource Availability for Requirement Group API and the Create Requirement Group Bookings API to book the resources that meet the needs you identify in your requirement groups. 

- The [Search Resource Availability for Requirement Group](#bkmk_sra_rg) API returns available time slots for resources when you search by using requirement groups.
- The [Create Requirement Group Bookings](#bkmk_crgb) API uses the available time slots for resources to generate booking records for your requirement groups.

You pass the details of a requirement group in your API calls and retrieve a list of available resources and their open time slots. This is helpful for self-scheduling scenarios, where a user wants to view the availability of resources, or for portal scheduling scenarios where a customer wants to view resource availability from a website or app.

### Prerequisites

- Dynamics 365 version 9.0 or above with Universal Resource Scheduling version 3.12.x.x

<a name="bkmk_sra_rg"></a>

## Search Resource Availability for Requirement Group API

Use the following input and output parameters for the Search Resource Availability for Requirement Group (**msdyn_SearchResourceAvailabilityForRequirementGroup**) API.
<!--In this table, like many in the topic, it's confusing to have rows with blank columns with no explanation. In a case like the row for RequirementSpecification, if Duration, Start, End, and Fulfillment Preference all pertain to RequirementsSpecification, there should be no row dividers between them. this can be accomplished with HTML table markup -->
### Input parameters

|   |   |   |
|-----------------|--|--|
|Version (String) |  |Required|
|RequirementGroup (Entity Reference)| |Required|
|RequirementSpecification (ResourceRequirement)|Duration (Integer)| Optional; if left null, respects the targeting<!--What does "targeting" mean here?--> requirement group duration by default|
|  |Start (DateTime)|Optional; if left null, respects the targeting requirement group start by default |
|  |End (DateTime)  |Optional; if left null, respects the targeting requirement group end by default |
|  |Fulfillment Preference (Entity Reference)|Optional; respects interval and ResultsPerIntervals fields only. If left null, respects the interval and ResultPerInterval fields of the targeting requirement group.|
|Settings (Settings)|SortOption (Integer)| Optional|
| |ConsiderSlotsWithOverlappingBooking (Boolean)|Optional; false by default|
| |ConsiderSlotsWithProposedBooking (Boolean)|Optional; false by default|
| |ConsiderSlotsWithLessThanRequiredDuration (Boolean)|Optional; false by default|
| |PageSize (Integer)|Optional|
| |PageNumber (Integer)|Optional|
| |PageCookie (String)|Optional|
| |OrganizationUnits (List<<Guide>Guide>)<!--What does this pattern "List<Guide>Guide" mean? -->|Optional|
| |RequiredSources (List<<Guide>Guide>)|Optional|


INSERT TABLE MARKUP HERE%%%

### Output parameters
| |  |
|-|--|
|Time slot |StartTime (DateTime)                 |
|         |EndTime (DateTime)                    |
|         |ArrivalTime (DateTime)                |
|         |Effort (Double)                       |
|         |IsDuplicate (Boolean)                 |
|         |Resource (Resource)                   |
|         |Location (TimeSlotLocation)           |
|         |TimeGroup (TimeSlotTimeGroup)         |
|         |AvailableIntervals (List<<Guide>OutputTimeSlot>)|
|Resource |Resource (EntityReference)|
|         |BusinessUnit (EntityReference) |
|         |OrganizationUnit (EntityReference) |
|         |ResourceType (Int)                 |
|         |PoolID (Guid)                      |
|         |CrewID (Guid)                      |
|         |Email (String)                     |
|         |Phone (String)                     |
|         |ImagePath (String)                 |
|Requirements|Requirement (EntityReference)   |
|            |ConstrainBag (String)           |
|            |Resource (List<<EntityReference>EntityReference>)   |
|ProposalResourceAssignmentSet|IntervalStart (DateTime)|
|   |ProposalResourceAssignment (List<<OutputProposalResourceGroup>OutputProposalResourceGroup>)|
|Paginginfos |MoreResults (Boolean)|
|            |PagingCookie (String)|


### Example

```http
{
  "RequestName": "msdyn_SearchResourceAvailabilityForRequirementGroup",
  "Parameters": [
    {
      "Key": "Version",
      "Value": "1.0.0"
    },
    {
      "Key": "RequirementGroup",
      "Value": {
        "Id": "6927721a-0137-42be-8092-26995625a9d9",
        "LogicalName": "msdyn_requirementgroup",
        "Name": null,
        "KeyAttributes": [],
        "RowVersion": null
      }
    }
  ],
  "RequestId": null
}
```

**Response**

```json
{
  "ResponseName": "msdyn_SearchResourceAvailabilityForRequirementGroup",
  "Results": [
    {
      "Key": "TimeSlots",
      "Value": {
        "Entities": [
          {
            "LogicalName": "organization",
            "Id": "00000000-0000-0000-0000-000000000000",
            "Attributes": [
              {
                "Key": "StartTime",
                "Value": "2020-03-09T08:11:00Z"
              },
              {
                "Key": "EndTime",
                "Value": "2020-04-25T23:59:00Z"
              },
              {
                "Key": "ArrivalTime",
                "Value": "2020-03-09T08:11:00Z"
              },
              {
                "Key": "Travel",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [
                    {
                      "Key": "Distance",
                      "Value": 0
                    },
                    {
                      "Key": "TravelTime",
                      "Value": 0
                    }
                  ],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              },
              {
                "Key": "Effort",
                "Value": 1
              },
              {
                "Key": "Location",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [
                    {
                      "Key": "Latitude",
                      "Value": 0
                    },
                    {
                      "Key": "Longitude",
                      "Value": 0
                    }
                  ],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              },
              {
                "Key": "TimeGroup",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              },
              {
                "Key": "IsDuplicate",
                "Value": false
              },
              {
                "Key": "Resource",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [
                    {
                      "Key": "Resource",
                      "Value": {
                        "Id": "34d67b43-8160-4573-b815-9ae24cd4d905",
                        "LogicalName": "bookableresource",
                        "Name": null,
                        "KeyAttributes": [],
                        "RowVersion": null
                      }
                    },
                    {
                      "Key": "BusinessUnit",
                      "Value": {
                        "Id": "641f2a4d-805a-ea11-a81d-000d3aaa5cbe",
                        "LogicalName": "businessunit",
                        "Name": null,
                        "KeyAttributes": [],
                        "RowVersion": null
                      }
                    },
                    {
                      "Key": "OrganizationalUnit",
                      "Value": {
                        "Id": "399ea61b-4c5c-ea11-a81e-000d3aaa5cbe",
                        "LogicalName": "msdyn_organizationalunit",
                        "Name": null,
                        "KeyAttributes": [],
                        "RowVersion": null
                      }
                    },
                    {
                      "Key": "ResourceType",
                      "Value": 0
                    },
                    {
                      "Key": "PoolId",
                      "Value": "00000000-0000-0000-0000-000000000000"
                    },
                    {
                      "Key": "CrewId",
                      "Value": "00000000-0000-0000-0000-000000000000"
                    }
                  ],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              }
            ],
            "EntityState": null,
            "FormattedValues": [],
            "RelatedEntities": [],
            "RowVersion": null,
            "KeyAttributes": []
          },
          {
            "LogicalName": "organization",
            "Id": "00000000-0000-0000-0000-000000000000",
            "Attributes": [
              {
                "Key": "StartTime",
                "Value": "2020-03-09T08:11:00Z"
              },
              {
                "Key": "EndTime",
                "Value": "2020-04-25T23:59:00Z"
              },
              {
                "Key": "ArrivalTime",
                "Value": "2020-03-09T08:11:00Z"
              },
              {
                "Key": "Travel",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [
                    {
                      "Key": "Distance",
                      "Value": 0
                    },
                    {
                      "Key": "TravelTime",
                      "Value": 0
                    }
                  ],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              },
              {
                "Key": "Effort",
                "Value": 1
              },
              {
                "Key": "Location",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [
                    {
                      "Key": "Latitude",
                      "Value": 0
                    },
                    {
                      "Key": "Longitude",
                      "Value": 0
                    }
                  ],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              },
              {
                "Key": "TimeGroup",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              },
              {
                "Key": "IsDuplicate",
                "Value": false
              },
              {
                "Key": "Resource",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [
                    {
                      "Key": "Resource",
                      "Value": {
                        "Id": "cb69fd6f-3091-433a-bb14-20c0b542a581",
                        "LogicalName": "bookableresource",
                        "Name": null,
                        "KeyAttributes": [],
                        "RowVersion": null
                      }
                    },
                    {
                      "Key": "BusinessUnit",
                      "Value": {
                        "Id": "641f2a4d-805a-ea11-a81d-000d3aaa5cbe",
                        "LogicalName": "businessunit",
                        "Name": null,
                        "KeyAttributes": [],
                        "RowVersion": null
                      }
                    },
                    {
                      "Key": "OrganizationalUnit",
                      "Value": {
                        "Id": "399ea61b-4c5c-ea11-a81e-000d3aaa5cbe",
                        "LogicalName": "msdyn_organizationalunit",
                        "Name": null,
                        "KeyAttributes": [],
                        "RowVersion": null
                      }
                    },
                    {
                      "Key": "ResourceType",
                      "Value": 0
                    },
                    {
                      "Key": "PoolId",
                      "Value": "00000000-0000-0000-0000-000000000000"
                    },
                    {
                      "Key": "CrewId",
                      "Value": "00000000-0000-0000-0000-000000000000"
                    }
                  ],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              }
            ],
            "EntityState": null,
            "FormattedValues": [],
            "RelatedEntities": [],
            "RowVersion": null,
            "KeyAttributes": []
          },
          {
            "LogicalName": "organization",
            "Id": "00000000-0000-0000-0000-000000000000",
            "Attributes": [
              {
                "Key": "StartTime",
                "Value": "2020-03-09T08:11:00Z"
              },
              {
                "Key": "EndTime",
                "Value": "2020-04-25T23:59:00Z"
              },
              {
                "Key": "ArrivalTime",
                "Value": "2020-03-09T08:11:00Z"
              },
              {
                "Key": "Travel",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [
                    {
                      "Key": "Distance",
                      "Value": 0
                    },
                    {
                      "Key": "TravelTime",
                      "Value": 0
                    }
                  ],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              },
              {
                "Key": "Effort",
                "Value": 1
              },
              {
                "Key": "Location",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [
                    {
                      "Key": "Latitude",
                      "Value": 0
                    },
                    {
                      "Key": "Longitude",
                      "Value": 0
                    }
                  ],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              },
              {
                "Key": "TimeGroup",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              },
              {
                "Key": "IsDuplicate",
                "Value": false
              },
              {
                "Key": "Resource",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [
                    {
                      "Key": "Resource",
                      "Value": {
                        "Id": "69f8d921-10c7-4d6f-8bca-3345d36b21ca",
                        "LogicalName": "bookableresource",
                        "Name": null,
                        "KeyAttributes": [],
                        "RowVersion": null
                      }
                    },
                    {
                      "Key": "BusinessUnit",
                      "Value": {
                        "Id": "641f2a4d-805a-ea11-a81d-000d3aaa5cbe",
                        "LogicalName": "businessunit",
                        "Name": null,
                        "KeyAttributes": [],
                        "RowVersion": null
                      }
                    },
                    {
                      "Key": "OrganizationalUnit",
                      "Value": {
                        "Id": "399ea61b-4c5c-ea11-a81e-000d3aaa5cbe",
                        "LogicalName": "msdyn_organizationalunit",
                        "Name": null,
                        "KeyAttributes": [],
                        "RowVersion": null
                      }
                    },
                    {
                      "Key": "ResourceType",
                      "Value": 0
                    },
                    {
                      "Key": "PoolId",
                      "Value": "00000000-0000-0000-0000-000000000000"
                    },
                    {
                      "Key": "CrewId",
                      "Value": "00000000-0000-0000-0000-000000000000"
                    }
                  ],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              }
            ],
            "EntityState": null,
            "FormattedValues": [],
            "RelatedEntities": [],
            "RowVersion": null,
            "KeyAttributes": []
          },
          {
            "LogicalName": "organization",
            "Id": "00000000-0000-0000-0000-000000000000",
            "Attributes": [
              {
                "Key": "StartTime",
                "Value": "2020-03-09T08:11:00Z"
              },
              {
                "Key": "EndTime",
                "Value": "2020-04-25T23:59:00Z"
              },
              {
                "Key": "ArrivalTime",
                "Value": "2020-03-09T08:11:00Z"
              },
              {
                "Key": "Travel",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [
                    {
                      "Key": "Distance",
                      "Value": 0
                    },
                    {
                      "Key": "TravelTime",
                      "Value": 0
                    }
                  ],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              },
              {
                "Key": "Effort",
                "Value": 1
              },
              {
                "Key": "Location",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [
                    {
                      "Key": "Latitude",
                      "Value": 0
                    },
                    {
                      "Key": "Longitude",
                      "Value": 0
                    }
                  ],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              },
              {
                "Key": "TimeGroup",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              },
              {
                "Key": "IsDuplicate",
                "Value": false
              },
              {
                "Key": "Resource",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [
                    {
                      "Key": "Resource",
                      "Value": {
                        "Id": "15722b27-facb-45e6-b262-afb30ed29382",
                        "LogicalName": "bookableresource",
                        "Name": null,
                        "KeyAttributes": [],
                        "RowVersion": null
                      }
                    },
                    {
                      "Key": "BusinessUnit",
                      "Value": {
                        "Id": "641f2a4d-805a-ea11-a81d-000d3aaa5cbe",
                        "LogicalName": "businessunit",
                        "Name": null,
                        "KeyAttributes": [],
                        "RowVersion": null
                      }
                    },
                    {
                      "Key": "OrganizationalUnit",
                      "Value": {
                        "Id": "399ea61b-4c5c-ea11-a81e-000d3aaa5cbe",
                        "LogicalName": "msdyn_organizationalunit",
                        "Name": null,
                        "KeyAttributes": [],
                        "RowVersion": null
                      }
                    },
                    {
                      "Key": "ResourceType",
                      "Value": 0
                    },
                    {
                      "Key": "PoolId",
                      "Value": "00000000-0000-0000-0000-000000000000"
                    },
                    {
                      "Key": "CrewId",
                      "Value": "00000000-0000-0000-0000-000000000000"
                    }
                  ],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              }
            ],
            "EntityState": null,
            "FormattedValues": [],
            "RelatedEntities": [],
            "RowVersion": null,
            "KeyAttributes": []
          },
          {
            "LogicalName": "organization",
            "Id": "00000000-0000-0000-0000-000000000000",
            "Attributes": [
              {
                "Key": "StartTime",
                "Value": "2020-03-09T08:11:00Z"
              },
              {
                "Key": "EndTime",
                "Value": "2020-04-25T23:59:00Z"
              },
              {
                "Key": "ArrivalTime",
                "Value": "2020-03-09T08:11:00Z"
              },
              {
                "Key": "Travel",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [
                    {
                      "Key": "Distance",
                      "Value": 0
                    },
                    {
                      "Key": "TravelTime",
                      "Value": 0
                    }
                  ],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              },
              {
                "Key": "Effort",
                "Value": 1
              },
              {
                "Key": "Location",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [
                    {
                      "Key": "Latitude",
                      "Value": 0
                    },
                    {
                      "Key": "Longitude",
                      "Value": 0
                    }
                  ],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              },
              {
                "Key": "TimeGroup",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              },
              {
                "Key": "IsDuplicate",
                "Value": false
              },
              {
                "Key": "Resource",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [
                    {
                      "Key": "Resource",
                      "Value": {
                        "Id": "b2d3bc55-9c75-4447-ba7c-5336bd081cb1",
                        "LogicalName": "bookableresource",
                        "Name": null,
                        "KeyAttributes": [],
                        "RowVersion": null
                      }
                    },
                    {
                      "Key": "BusinessUnit",
                      "Value": {
                        "Id": "641f2a4d-805a-ea11-a81d-000d3aaa5cbe",
                        "LogicalName": "businessunit",
                        "Name": null,
                        "KeyAttributes": [],
                        "RowVersion": null
                      }
                    },
                    {
                      "Key": "OrganizationalUnit",
                      "Value": {
                        "Id": "00000000-0000-0000-0000-000000000000",
                        "LogicalName": "msdyn_organizationalunit",
                        "Name": null,
                        "KeyAttributes": [],
                        "RowVersion": null
                      }
                    },
                    {
                      "Key": "ResourceType",
                      "Value": 0
                    },
                    {
                      "Key": "PoolId",
                      "Value": "00000000-0000-0000-0000-000000000000"
                    },
                    {
                      "Key": "CrewId",
                      "Value": "00000000-0000-0000-0000-000000000000"
                    }
                  ],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              }
            ],
            "EntityState": null,
            "FormattedValues": [],
            "RelatedEntities": [],
            "RowVersion": null,
            "KeyAttributes": []
          },
          {
            "LogicalName": "organization",
            "Id": "00000000-0000-0000-0000-000000000000",
            "Attributes": [
              {
                "Key": "StartTime",
                "Value": "2020-03-09T08:11:00Z"
              },
              {
                "Key": "EndTime",
                "Value": "2020-04-25T23:59:00Z"
              },
              {
                "Key": "ArrivalTime",
                "Value": "2020-03-09T08:11:00Z"
              },
              {
                "Key": "Travel",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [
                    {
                      "Key": "Distance",
                      "Value": 0
                    },
                    {
                      "Key": "TravelTime",
                      "Value": 0
                    }
                  ],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              },
              {
                "Key": "Effort",
                "Value": 1
              },
              {
                "Key": "Location",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [
                    {
                      "Key": "Latitude",
                      "Value": 0
                    },
                    {
                      "Key": "Longitude",
                      "Value": 0
                    }
                  ],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              },
              {
                "Key": "TimeGroup",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              },
              {
                "Key": "IsDuplicate",
                "Value": false
              },
              {
                "Key": "Resource",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [
                    {
                      "Key": "Resource",
                      "Value": {
                        "Id": "d8e264aa-af93-49ed-89e8-321e3a1d4abf",
                        "LogicalName": "bookableresource",
                        "Name": null,
                        "KeyAttributes": [],
                        "RowVersion": null
                      }
                    },
                    {
                      "Key": "BusinessUnit",
                      "Value": {
                        "Id": "641f2a4d-805a-ea11-a81d-000d3aaa5cbe",
                        "LogicalName": "businessunit",
                        "Name": null,
                        "KeyAttributes": [],
                        "RowVersion": null
                      }
                    },
                    {
                      "Key": "OrganizationalUnit",
                      "Value": {
                        "Id": "95eb0d22-4c5c-ea11-a81e-000d3aaa5cbe",
                        "LogicalName": "msdyn_organizationalunit",
                        "Name": null,
                        "KeyAttributes": [],
                        "RowVersion": null
                      }
                    },
                    {
                      "Key": "ResourceType",
                      "Value": 0
                    },
                    {
                      "Key": "PoolId",
                      "Value": "00000000-0000-0000-0000-000000000000"
                    },
                    {
                      "Key": "CrewId",
                      "Value": "00000000-0000-0000-0000-000000000000"
                    }
                  ],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              }
            ],
            "EntityState": null,
            "FormattedValues": [],
            "RelatedEntities": [],
            "RowVersion": null,
            "KeyAttributes": []
          },
          {
            "LogicalName": "organization",
            "Id": "00000000-0000-0000-0000-000000000000",
            "Attributes": [
              {
                "Key": "StartTime",
                "Value": "2020-03-09T08:11:00Z"
              },
              {
                "Key": "EndTime",
                "Value": "2020-04-25T23:59:00Z"
              },
              {
                "Key": "ArrivalTime",
                "Value": "2020-03-09T08:11:00Z"
              },
              {
                "Key": "Travel",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [
                    {
                      "Key": "Distance",
                      "Value": 0
                    },
                    {
                      "Key": "TravelTime",
                      "Value": 0
                    }
                  ],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              },
              {
                "Key": "Effort",
                "Value": 1
              },
              {
                "Key": "Location",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [
                    {
                      "Key": "Latitude",
                      "Value": 0
                    },
                    {
                      "Key": "Longitude",
                      "Value": 0
                    }
                  ],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              },
              {
                "Key": "TimeGroup",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              },
              {
                "Key": "IsDuplicate",
                "Value": false
              },
              {
                "Key": "Resource",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [
                    {
                      "Key": "Resource",
                      "Value": {
                        "Id": "bc095d77-fa68-4fa7-b80a-fcfb0fd32087",
                        "LogicalName": "bookableresource",
                        "Name": null,
                        "KeyAttributes": [],
                        "RowVersion": null
                      }
                    },
                    {
                      "Key": "BusinessUnit",
                      "Value": {
                        "Id": "641f2a4d-805a-ea11-a81d-000d3aaa5cbe",
                        "LogicalName": "businessunit",
                        "Name": null,
                        "KeyAttributes": [],
                        "RowVersion": null
                      }
                    },
                    {
                      "Key": "OrganizationalUnit",
                      "Value": {
                        "Id": "95eb0d22-4c5c-ea11-a81e-000d3aaa5cbe",
                        "LogicalName": "msdyn_organizationalunit",
                        "Name": null,
                        "KeyAttributes": [],
                        "RowVersion": null
                      }
                    },
                    {
                      "Key": "ResourceType",
                      "Value": 0
                    },
                    {
                      "Key": "PoolId",
                      "Value": "00000000-0000-0000-0000-000000000000"
                    },
                    {
                      "Key": "CrewId",
                      "Value": "00000000-0000-0000-0000-000000000000"
                    }
                  ],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              }
            ],
            "EntityState": null,
            "FormattedValues": [],
            "RelatedEntities": [],
            "RowVersion": null,
            "KeyAttributes": []
          },
          {
            "LogicalName": "organization",
            "Id": "00000000-0000-0000-0000-000000000000",
            "Attributes": [
              {
                "Key": "StartTime",
                "Value": "2020-03-09T08:11:00Z"
              },
              {
                "Key": "EndTime",
                "Value": "2020-04-25T23:59:00Z"
              },
              {
                "Key": "ArrivalTime",
                "Value": "2020-03-09T08:11:00Z"
              },
              {
                "Key": "Travel",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [
                    {
                      "Key": "Distance",
                      "Value": 0
                    },
                    {
                      "Key": "TravelTime",
                      "Value": 0
                    }
                  ],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              },
              {
                "Key": "Effort",
                "Value": 1
              },
              {
                "Key": "Location",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [
                    {
                      "Key": "Latitude",
                      "Value": 0
                    },
                    {
                      "Key": "Longitude",
                      "Value": 0
                    }
                  ],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              },
              {
                "Key": "TimeGroup",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              },
              {
                "Key": "IsDuplicate",
                "Value": false
              },
              {
                "Key": "Resource",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [
                    {
                      "Key": "Resource",
                      "Value": {
                        "Id": "6116cec7-e4ad-4d25-aa67-6aa029bcc30b",
                        "LogicalName": "bookableresource",
                        "Name": null,
                        "KeyAttributes": [],
                        "RowVersion": null
                      }
                    },
                    {
                      "Key": "BusinessUnit",
                      "Value": {
                        "Id": "641f2a4d-805a-ea11-a81d-000d3aaa5cbe",
                        "LogicalName": "businessunit",
                        "Name": null,
                        "KeyAttributes": [],
                        "RowVersion": null
                      }
                    },
                    {
                      "Key": "OrganizationalUnit",
                      "Value": {
                        "Id": "95eb0d22-4c5c-ea11-a81e-000d3aaa5cbe",
                        "LogicalName": "msdyn_organizationalunit",
                        "Name": null,
                        "KeyAttributes": [],
                        "RowVersion": null
                      }
                    },
                    {
                      "Key": "ResourceType",
                      "Value": 0
                    },
                    {
                      "Key": "PoolId",
                      "Value": "00000000-0000-0000-0000-000000000000"
                    },
                    {
                      "Key": "CrewId",
                      "Value": "00000000-0000-0000-0000-000000000000"
                    }
                  ],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              }
            ],
            "EntityState": null,
            "FormattedValues": [],
            "RelatedEntities": [],
            "RowVersion": null,
            "KeyAttributes": []
          },
          {
            "LogicalName": "organization",
            "Id": "00000000-0000-0000-0000-000000000000",
            "Attributes": [
              {
                "Key": "StartTime",
                "Value": "2020-03-09T08:11:00Z"
              },
              {
                "Key": "EndTime",
                "Value": "2020-04-25T23:59:00Z"
              },
              {
                "Key": "ArrivalTime",
                "Value": "2020-03-09T08:11:00Z"
              },
              {
                "Key": "Travel",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [
                    {
                      "Key": "Distance",
                      "Value": 0
                    },
                    {
                      "Key": "TravelTime",
                      "Value": 0
                    }
                  ],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              },
              {
                "Key": "Effort",
                "Value": 1
              },
              {
                "Key": "Location",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [
                    {
                      "Key": "Latitude",
                      "Value": 0
                    },
                    {
                      "Key": "Longitude",
                      "Value": 0
                    }
                  ],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              },
              {
                "Key": "TimeGroup",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              },
              {
                "Key": "IsDuplicate",
                "Value": false
              },
              {
                "Key": "Resource",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [
                    {
                      "Key": "Resource",
                      "Value": {
                        "Id": "a0fd36d1-dcb0-41d1-968d-c5fa214702e7",
                        "LogicalName": "bookableresource",
                        "Name": null,
                        "KeyAttributes": [],
                        "RowVersion": null
                      }
                    },
                    {
                      "Key": "BusinessUnit",
                      "Value": {
                        "Id": "641f2a4d-805a-ea11-a81d-000d3aaa5cbe",
                        "LogicalName": "businessunit",
                        "Name": null,
                        "KeyAttributes": [],
                        "RowVersion": null
                      }
                    },
                    {
                      "Key": "OrganizationalUnit",
                      "Value": {
                        "Id": "95eb0d22-4c5c-ea11-a81e-000d3aaa5cbe",
                        "LogicalName": "msdyn_organizationalunit",
                        "Name": null,
                        "KeyAttributes": [],
                        "RowVersion": null
                      }
                    },
                    {
                      "Key": "ResourceType",
                      "Value": 0
                    },
                    {
                      "Key": "PoolId",
                      "Value": "00000000-0000-0000-0000-000000000000"
                    },
                    {
                      "Key": "CrewId",
                      "Value": "00000000-0000-0000-0000-000000000000"
                    }
                  ],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              }
            ],
            "EntityState": null,
            "FormattedValues": [],
            "RelatedEntities": [],
            "RowVersion": null,
            "KeyAttributes": []
          },
          {
            "LogicalName": "organization",
            "Id": "00000000-0000-0000-0000-000000000000",
            "Attributes": [
              {
                "Key": "StartTime",
                "Value": "2020-03-09T08:11:00Z"
              },
              {
                "Key": "EndTime",
                "Value": "2020-04-25T23:59:00Z"
              },
              {
                "Key": "ArrivalTime",
                "Value": "2020-03-09T08:11:00Z"
              },
              {
                "Key": "Travel",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [
                    {
                      "Key": "Distance",
                      "Value": 0
                    },
                    {
                      "Key": "TravelTime",
                      "Value": 0
                    }
                  ],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              },
              {
                "Key": "Effort",
                "Value": 1
              },
              {
                "Key": "Location",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [
                    {
                      "Key": "Latitude",
                      "Value": 0
                    },
                    {
                      "Key": "Longitude",
                      "Value": 0
                    }
                  ],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              },
              {
                "Key": "TimeGroup",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              },
              {
                "Key": "IsDuplicate",
                "Value": false
              },
              {
                "Key": "Resource",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [
                    {
                      "Key": "Resource",
                      "Value": {
                        "Id": "d97e6f62-ed34-4bbd-864e-e3f5b3e824cf",
                        "LogicalName": "bookableresource",
                        "Name": null,
                        "KeyAttributes": [],
                        "RowVersion": null
                      }
                    },
                    {
                      "Key": "BusinessUnit",
                      "Value": {
                        "Id": "641f2a4d-805a-ea11-a81d-000d3aaa5cbe",
                        "LogicalName": "businessunit",
                        "Name": null,
                        "KeyAttributes": [],
                        "RowVersion": null
                      }
                    },
                    {
                      "Key": "OrganizationalUnit",
                      "Value": {
                        "Id": "95eb0d22-4c5c-ea11-a81e-000d3aaa5cbe",
                        "LogicalName": "msdyn_organizationalunit",
                        "Name": null,
                        "KeyAttributes": [],
                        "RowVersion": null
                      }
                    },
                    {
                      "Key": "ResourceType",
                      "Value": 0
                    },
                    {
                      "Key": "PoolId",
                      "Value": "00000000-0000-0000-0000-000000000000"
                    },
                    {
                      "Key": "CrewId",
                      "Value": "00000000-0000-0000-0000-000000000000"
                    }
                  ],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              }
            ],
            "EntityState": null,
            "FormattedValues": [],
            "RelatedEntities": [],
            "RowVersion": null,
            "KeyAttributes": []
          },
          {
            "LogicalName": "organization",
            "Id": "00000000-0000-0000-0000-000000000000",
            "Attributes": [
              {
                "Key": "StartTime",
                "Value": "2020-03-09T08:11:00Z"
              },
              {
                "Key": "EndTime",
                "Value": "2020-04-25T23:59:00Z"
              },
              {
                "Key": "ArrivalTime",
                "Value": "2020-03-09T08:11:00Z"
              },
              {
                "Key": "Travel",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [
                    {
                      "Key": "Distance",
                      "Value": 0
                    },
                    {
                      "Key": "TravelTime",
                      "Value": 0
                    }
                  ],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              },
              {
                "Key": "Effort",
                "Value": 1
              },
              {
                "Key": "Location",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [
                    {
                      "Key": "Latitude",
                      "Value": 0
                    },
                    {
                      "Key": "Longitude",
                      "Value": 0
                    }
                  ],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              },
              {
                "Key": "TimeGroup",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              },
              {
                "Key": "IsDuplicate",
                "Value": false
              },
              {
                "Key": "Resource",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [
                    {
                      "Key": "Resource",
                      "Value": {
                        "Id": "617ec1ab-6e05-455b-a125-dab6f472106a",
                        "LogicalName": "bookableresource",
                        "Name": null,
                        "KeyAttributes": [],
                        "RowVersion": null
                      }
                    },
                    {
                      "Key": "BusinessUnit",
                      "Value": {
                        "Id": "641f2a4d-805a-ea11-a81d-000d3aaa5cbe",
                        "LogicalName": "businessunit",
                        "Name": null,
                        "KeyAttributes": [],
                        "RowVersion": null
                      }
                    },
                    {
                      "Key": "OrganizationalUnit",
                      "Value": {
                        "Id": "399ea61b-4c5c-ea11-a81e-000d3aaa5cbe",
                        "LogicalName": "msdyn_organizationalunit",
                        "Name": null,
                        "KeyAttributes": [],
                        "RowVersion": null
                      }
                    },
                    {
                      "Key": "ResourceType",
                      "Value": 0
                    },
                    {
                      "Key": "PoolId",
                      "Value": "00000000-0000-0000-0000-000000000000"
                    },
                    {
                      "Key": "CrewId",
                      "Value": "00000000-0000-0000-0000-000000000000"
                    }
                  ],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              }
            ],
            "EntityState": null,
            "FormattedValues": [],
            "RelatedEntities": [],
            "RowVersion": null,
            "KeyAttributes": []
          },
          {
            "LogicalName": "organization",
            "Id": "00000000-0000-0000-0000-000000000000",
            "Attributes": [
              {
                "Key": "StartTime",
                "Value": "2020-03-09T08:11:00Z"
              },
              {
                "Key": "EndTime",
                "Value": "2020-04-25T23:59:00Z"
              },
              {
                "Key": "ArrivalTime",
                "Value": "2020-03-09T08:11:00Z"
              },
              {
                "Key": "Travel",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [
                    {
                      "Key": "Distance",
                      "Value": 0
                    },
                    {
                      "Key": "TravelTime",
                      "Value": 0
                    }
                  ],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              },
              {
                "Key": "Effort",
                "Value": 1
              },
              {
                "Key": "Location",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [
                    {
                      "Key": "Latitude",
                      "Value": 0
                    },
                    {
                      "Key": "Longitude",
                      "Value": 0
                    }
                  ],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              },
              {
                "Key": "TimeGroup",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              },
              {
                "Key": "IsDuplicate",
                "Value": false
              },
              {
                "Key": "Resource",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [
                    {
                      "Key": "Resource",
                      "Value": {
                        "Id": "26592224-35eb-4215-b990-1d7f561d7edd",
                        "LogicalName": "bookableresource",
                        "Name": null,
                        "KeyAttributes": [],
                        "RowVersion": null
                      }
                    },
                    {
                      "Key": "BusinessUnit",
                      "Value": {
                        "Id": "641f2a4d-805a-ea11-a81d-000d3aaa5cbe",
                        "LogicalName": "businessunit",
                        "Name": null,
                        "KeyAttributes": [],
                        "RowVersion": null
                      }
                    },
                    {
                      "Key": "OrganizationalUnit",
                      "Value": {
                        "Id": "399ea61b-4c5c-ea11-a81e-000d3aaa5cbe",
                        "LogicalName": "msdyn_organizationalunit",
                        "Name": null,
                        "KeyAttributes": [],
                        "RowVersion": null
                      }
                    },
                    {
                      "Key": "ResourceType",
                      "Value": 0
                    },
                    {
                      "Key": "PoolId",
                      "Value": "00000000-0000-0000-0000-000000000000"
                    },
                    {
                      "Key": "CrewId",
                      "Value": "00000000-0000-0000-0000-000000000000"
                    }
                  ],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              }
            ],
            "EntityState": null,
            "FormattedValues": [],
            "RelatedEntities": [],
            "RowVersion": null,
            "KeyAttributes": []
          },
          {
            "LogicalName": "organization",
            "Id": "00000000-0000-0000-0000-000000000000",
            "Attributes": [
              {
                "Key": "StartTime",
                "Value": "2020-03-09T08:11:00Z"
              },
              {
                "Key": "EndTime",
                "Value": "2020-04-25T23:59:00Z"
              },
              {
                "Key": "ArrivalTime",
                "Value": "2020-03-09T08:11:00Z"
              },
              {
                "Key": "Travel",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [
                    {
                      "Key": "Distance",
                      "Value": 0
                    },
                    {
                      "Key": "TravelTime",
                      "Value": 0
                    }
                  ],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              },
              {
                "Key": "Effort",
                "Value": 1
              },
              {
                "Key": "Location",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [
                    {
                      "Key": "Latitude",
                      "Value": 0
                    },
                    {
                      "Key": "Longitude",
                      "Value": 0
                    }
                  ],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              },
              {
                "Key": "TimeGroup",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              },
              {
                "Key": "IsDuplicate",
                "Value": false
              },
              {
                "Key": "Resource",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [
                    {
                      "Key": "Resource",
                      "Value": {
                        "Id": "59178960-dca6-41fd-9681-c252a12d166e",
                        "LogicalName": "bookableresource",
                        "Name": null,
                        "KeyAttributes": [],
                        "RowVersion": null
                      }
                    },
                    {
                      "Key": "BusinessUnit",
                      "Value": {
                        "Id": "641f2a4d-805a-ea11-a81d-000d3aaa5cbe",
                        "LogicalName": "businessunit",
                        "Name": null,
                        "KeyAttributes": [],
                        "RowVersion": null
                      }
                    },
                    {
                      "Key": "OrganizationalUnit",
                      "Value": {
                        "Id": "399ea61b-4c5c-ea11-a81e-000d3aaa5cbe",
                        "LogicalName": "msdyn_organizationalunit",
                        "Name": null,
                        "KeyAttributes": [],
                        "RowVersion": null
                      }
                    },
                    {
                      "Key": "ResourceType",
                      "Value": 0
                    },
                    {
                      "Key": "PoolId",
                      "Value": "00000000-0000-0000-0000-000000000000"
                    },
                    {
                      "Key": "CrewId",
                      "Value": "00000000-0000-0000-0000-000000000000"
                    }
                  ],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              }
            ],
            "EntityState": null,
            "FormattedValues": [],
            "RelatedEntities": [],
            "RowVersion": null,
            "KeyAttributes": []
          },
          {
            "LogicalName": "organization",
            "Id": "00000000-0000-0000-0000-000000000000",
            "Attributes": [
              {
                "Key": "StartTime",
                "Value": "2020-03-09T08:11:00Z"
              },
              {
                "Key": "EndTime",
                "Value": "2020-04-25T23:59:00Z"
              },
              {
                "Key": "ArrivalTime",
                "Value": "2020-03-09T08:11:00Z"
              },
              {
                "Key": "Travel",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [
                    {
                      "Key": "Distance",
                      "Value": 0
                    },
                    {
                      "Key": "TravelTime",
                      "Value": 0
                    }
                  ],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              },
              {
                "Key": "Effort",
                "Value": 1
              },
              {
                "Key": "Location",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [
                    {
                      "Key": "Latitude",
                      "Value": 0
                    },
                    {
                      "Key": "Longitude",
                      "Value": 0
                    }
                  ],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              },
              {
                "Key": "TimeGroup",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              },
              {
                "Key": "IsDuplicate",
                "Value": false
              },
              {
                "Key": "Resource",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [
                    {
                      "Key": "Resource",
                      "Value": {
                        "Id": "62fd4fce-1f1e-4835-915e-fe67201234a2",
                        "LogicalName": "bookableresource",
                        "Name": null,
                        "KeyAttributes": [],
                        "RowVersion": null
                      }
                    },
                    {
                      "Key": "BusinessUnit",
                      "Value": {
                        "Id": "641f2a4d-805a-ea11-a81d-000d3aaa5cbe",
                        "LogicalName": "businessunit",
                        "Name": null,
                        "KeyAttributes": [],
                        "RowVersion": null
                      }
                    },
                    {
                      "Key": "OrganizationalUnit",
                      "Value": {
                        "Id": "399ea61b-4c5c-ea11-a81e-000d3aaa5cbe",
                        "LogicalName": "msdyn_organizationalunit",
                        "Name": null,
                        "KeyAttributes": [],
                        "RowVersion": null
                      }
                    },
                    {
                      "Key": "ResourceType",
                      "Value": 0
                    },
                    {
                      "Key": "PoolId",
                      "Value": "00000000-0000-0000-0000-000000000000"
                    },
                    {
                      "Key": "CrewId",
                      "Value": "00000000-0000-0000-0000-000000000000"
                    }
                  ],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              }
            ],
            "EntityState": null,
            "FormattedValues": [],
            "RelatedEntities": [],
            "RowVersion": null,
            "KeyAttributes": []
          },
          {
            "LogicalName": "organization",
            "Id": "00000000-0000-0000-0000-000000000000",
            "Attributes": [
              {
                "Key": "StartTime",
                "Value": "2020-03-09T08:11:00Z"
              },
              {
                "Key": "EndTime",
                "Value": "2020-04-25T23:59:00Z"
              },
              {
                "Key": "ArrivalTime",
                "Value": "2020-03-09T08:11:00Z"
              },
              {
                "Key": "Travel",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [
                    {
                      "Key": "Distance",
                      "Value": 0
                    },
                    {
                      "Key": "TravelTime",
                      "Value": 0
                    }
                  ],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              },
              {
                "Key": "Effort",
                "Value": 1
              },
              {
                "Key": "Location",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [
                    {
                      "Key": "Latitude",
                      "Value": 0
                    },
                    {
                      "Key": "Longitude",
                      "Value": 0
                    }
                  ],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              },
              {
                "Key": "TimeGroup",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              },
              {
                "Key": "IsDuplicate",
                "Value": false
              },
              {
                "Key": "Resource",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [
                    {
                      "Key": "Resource",
                      "Value": {
                        "Id": "156be26c-fe0c-45c5-b1ed-591cb92f17a7",
                        "LogicalName": "bookableresource",
                        "Name": null,
                        "KeyAttributes": [],
                        "RowVersion": null
                      }
                    },
                    {
                      "Key": "BusinessUnit",
                      "Value": {
                        "Id": "641f2a4d-805a-ea11-a81d-000d3aaa5cbe",
                        "LogicalName": "businessunit",
                        "Name": null,
                        "KeyAttributes": [],
                        "RowVersion": null
                      }
                    },
                    {
                      "Key": "OrganizationalUnit",
                      "Value": {
                        "Id": "399ea61b-4c5c-ea11-a81e-000d3aaa5cbe",
                        "LogicalName": "msdyn_organizationalunit",
                        "Name": null,
                        "KeyAttributes": [],
                        "RowVersion": null
                      }
                    },
                    {
                      "Key": "ResourceType",
                      "Value": 0
                    },
                    {
                      "Key": "PoolId",
                      "Value": "00000000-0000-0000-0000-000000000000"
                    },
                    {
                      "Key": "CrewId",
                      "Value": "00000000-0000-0000-0000-000000000000"
                    }
                  ],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              }
            ],
            "EntityState": null,
            "FormattedValues": [],
            "RelatedEntities": [],
            "RowVersion": null,
            "KeyAttributes": []
          },
          {
            "LogicalName": "organization",
            "Id": "00000000-0000-0000-0000-000000000000",
            "Attributes": [
              {
                "Key": "StartTime",
                "Value": "2020-03-09T08:11:00Z"
              },
              {
                "Key": "EndTime",
                "Value": "2020-04-25T23:59:00Z"
              },
              {
                "Key": "ArrivalTime",
                "Value": "2020-03-09T08:11:00Z"
              },
              {
                "Key": "Travel",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [
                    {
                      "Key": "Distance",
                      "Value": 0
                    },
                    {
                      "Key": "TravelTime",
                      "Value": 0
                    }
                  ],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              },
              {
                "Key": "Effort",
                "Value": 1
              },
              {
                "Key": "Location",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [
                    {
                      "Key": "Latitude",
                      "Value": 0
                    },
                    {
                      "Key": "Longitude",
                      "Value": 0
                    }
                  ],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              },
              {
                "Key": "TimeGroup",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              },
              {
                "Key": "IsDuplicate",
                "Value": false
              },
              {
                "Key": "Resource",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [
                    {
                      "Key": "Resource",
                      "Value": {
                        "Id": "ebb71951-70a6-4f47-8ebb-7ed66e95ef8d",
                        "LogicalName": "bookableresource",
                        "Name": null,
                        "KeyAttributes": [],
                        "RowVersion": null
                      }
                    },
                    {
                      "Key": "BusinessUnit",
                      "Value": {
                        "Id": "641f2a4d-805a-ea11-a81d-000d3aaa5cbe",
                        "LogicalName": "businessunit",
                        "Name": null,
                        "KeyAttributes": [],
                        "RowVersion": null
                      }
                    },
                    {
                      "Key": "OrganizationalUnit",
                      "Value": {
                        "Id": "399ea61b-4c5c-ea11-a81e-000d3aaa5cbe",
                        "LogicalName": "msdyn_organizationalunit",
                        "Name": null,
                        "KeyAttributes": [],
                        "RowVersion": null
                      }
                    },
                    {
                      "Key": "ResourceType",
                      "Value": 0
                    },
                    {
                      "Key": "PoolId",
                      "Value": "00000000-0000-0000-0000-000000000000"
                    },
                    {
                      "Key": "CrewId",
                      "Value": "00000000-0000-0000-0000-000000000000"
                    }
                  ],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              }
            ],
            "EntityState": null,
            "FormattedValues": [],
            "RelatedEntities": [],
            "RowVersion": null,
            "KeyAttributes": []
          },
          {
            "LogicalName": "organization",
            "Id": "00000000-0000-0000-0000-000000000000",
            "Attributes": [
              {
                "Key": "StartTime",
                "Value": "2020-03-09T08:11:00Z"
              },
              {
                "Key": "EndTime",
                "Value": "2020-04-25T23:59:00Z"
              },
              {
                "Key": "ArrivalTime",
                "Value": "2020-03-09T08:11:00Z"
              },
              {
                "Key": "Travel",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [
                    {
                      "Key": "Distance",
                      "Value": 0
                    },
                    {
                      "Key": "TravelTime",
                      "Value": 0
                    }
                  ],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              },
              {
                "Key": "Effort",
                "Value": 1
              },
              {
                "Key": "Location",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [
                    {
                      "Key": "Latitude",
                      "Value": 0
                    },
                    {
                      "Key": "Longitude",
                      "Value": 0
                    }
                  ],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              },
              {
                "Key": "TimeGroup",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              },
              {
                "Key": "IsDuplicate",
                "Value": false
              },
              {
                "Key": "Resource",
                "Value": {
                  "LogicalName": "organization",
                  "Id": "00000000-0000-0000-0000-000000000000",
                  "Attributes": [
                    {
                      "Key": "Resource",
                      "Value": {
                        "Id": "12b9693b-793b-45b6-abd8-236ed0831ce5",
                        "LogicalName": "bookableresource",
                        "Name": null,
                        "KeyAttributes": [],
                        "RowVersion": null
                      }
                    },
                    {
                      "Key": "BusinessUnit",
                      "Value": {
                        "Id": "641f2a4d-805a-ea11-a81d-000d3aaa5cbe",
                        "LogicalName": "businessunit",
                        "Name": null,
                        "KeyAttributes": [],
                        "RowVersion": null
                      }
                    },
                    {
                      "Key": "OrganizationalUnit",
                      "Value": {
                        "Id": "00000000-0000-0000-0000-000000000000",
                        "LogicalName": "msdyn_organizationalunit",
                        "Name": null,
                        "KeyAttributes": [],
                        "RowVersion": null
                      }
                    },
                    {
                      "Key": "ResourceType",
                      "Value": 0
                    },
                    {
                      "Key": "PoolId",
                      "Value": "00000000-0000-0000-0000-000000000000"
                    },
                    {
                      "Key": "CrewId",
                      "Value": "00000000-0000-0000-0000-000000000000"
                    }
                  ],
                  "EntityState": null,
                  "FormattedValues": [],
                  "RelatedEntities": [],
                  "RowVersion": null,
                  "KeyAttributes": []
                }
              }
            ],
            "EntityState": null,
            "FormattedValues": [],
            "RelatedEntities": [],
            "RowVersion": null,
            "KeyAttributes": []
          }
        ],
        "MoreRecords": false,
        "PagingCookie": null,
        "MinActiveRowVersion": "",
        "TotalRecordCount": 0,
        "TotalRecordCountLimitExceeded": false,
        "EntityName": "organization"
      }
    },
    {
      "Key": "Requirements",
      "Value": {
        "Entities": [
          {
            "LogicalName": "organization",
            "Id": "00000000-0000-0000-0000-000000000000",
            "Attributes": [
              {
                "Key": "Requirement",
                "Value": {
                  "Id": "a80e4368-64d4-4d50-954c-0e6d8d7b8fb1",
                  "LogicalName": "msdyn_resourcerequirement",
                  "Name": null,
                  "KeyAttributes": [],
                  "RowVersion": null
                }
              },
              {
                "Key": "ConstraintBag",
                "Value": "{\"@ufx-logicalname\":\"msdyn_resourcerequirement\",\"Requirement\":{\"@ufx-id\":\"a80e4368-64d4-4d50-954c-0e6d8d7b8fb1\",\"@ufx-logicalname\":\"msdyn_resourcerequirement\",\"msdyn_templaterequirementid\":\"2348A07A-FE55-42E6-B44A-5DD841D1E678\",\"statecode\":0,\"statecode@ufx-type\":\"option\",\"statecode@ufx-formatvalue\":\"Active\",\"msdyn_requirementgroupid\":\"6927721a-0137-42be-8092-26995625a9d9\",\"msdyn_requirementgroupid@ufx-type\":\"lookup\",\"msdyn_requirementgroupid@ufx-formatvalue\":\"Doc SA1\",\"msdyn_requirementgroupid@ufx-logicalname\":\"msdyn_requirementgroup\",\"statuscode\":1,\"statuscode@ufx-type\":\"option\",\"statuscode@ufx-formatvalue\":\"Active\",\"msdyn_interval\":15,\"msdyn_interval@ufx-type\":\"int\",\"msdyn_interval@ufx-formatvalue\":\"15\",\"createdon\":\"2020-03-04T05:40:46Z\",\"createdon@ufx-type\":\"datetime\",\"createdon@ufx-formatvalue\":\"3/4/2020 5:40 AM\",\"msdyn_worklocation\":690970000,\"msdyn_worklocation@ufx-type\":\"option\",\"msdyn_worklocation@ufx-formatvalue\":\"Onsite\",\"msdyn_bookingsetupmetadataid\":\"651bd1e8-3a04-41a3-927c-aa1a71080293\",\"msdyn_bookingsetupmetadataid@ufx-type\":\"lookup\",\"msdyn_bookingsetupmetadataid@ufx-formatvalue\":\"serviceappointment\",\"msdyn_bookingsetupmetadataid@ufx-logicalname\":\"msdyn_bookingsetupmetadata\",\"msdyn_timegroup\":\"41c70d4a-919e-4d77-b5ed-d234977cab58\",\"msdyn_timegroup@ufx-type\":\"lookup\",\"msdyn_timegroup@ufx-formatvalue\":\"1 Service Individual Resources\",\"msdyn_timegroup@ufx-logicalname\":\"msdyn_timegroup\",\"ownerid\":\"56262a4d-805a-ea11-a81d-000d3aaa5cbe\",\"ownerid@ufx-type\":\"lookup\",\"ownerid@ufx-formatvalue\":\"First name Last name\",\"ownerid@ufx-logicalname\":\"systemuser\",\"msdyn_requirementgroupcontrolviewid\":\"0\",\"modifiedon\":\"2020-03-09T06:44:48Z\",\"modifiedon@ufx-type\":\"datetime\",\"modifiedon@ufx-formatvalue\":\"3/9/2020 6:44 AM\",\"msdyn_todate\":\"2020-04-25T23:59:00Z\",\"msdyn_todate@ufx-type\":\"datetime\",\"msdyn_todate@ufx-formatvalue\":\"4/25/2020\",\"msdyn_requirementrelationshipid\":\"85aee02f-57ee-4de5-a887-dff91d8e63dd\",\"msdyn_requirementrelationshipid@ufx-type\":\"lookup\",\"msdyn_requirementrelationshipid@ufx-formatvalue\":\"1 Service Individual Resources\",\"msdyn_requirementrelationshipid@ufx-logicalname\":\"msdyn_requirementrelationship\",\"msdyn_name\":\"New Resource Requirement\",\"timezoneruleversionnumber\":4,\"timezoneruleversionnumber@ufx-type\":\"int\",\"timezoneruleversionnumber@ufx-formatvalue\":\"4\",\"msdyn_effort\":1.0000000000,\"msdyn_effort@ufx-type\":\"decimal\",\"msdyn_effort@ufx-formatvalue\":\"1.0000\",\"msdyn_isprimary\":false,\"msdyn_isprimary@ufx-formatvalue\":\"No\",\"msdyn_resourcerequirementid\":\"a80e4368-64d4-4d50-954c-0e6d8d7b8fb1\",\"msdyn_resourcerequirementid@ufx-type\":\"guid\",\"modifiedby\":\"56262a4d-805a-ea11-a81d-000d3aaa5cbe\",\"modifiedby@ufx-type\":\"lookup\",\"modifiedby@ufx-formatvalue\":\"First name Last name\",\"modifiedby@ufx-logicalname\":\"systemuser\",\"msdyn_status\":\"f1f20cae-4a76-44eb-be6d-db346ba57013\",\"msdyn_status@ufx-type\":\"lookup\",\"msdyn_status@ufx-formatvalue\":\"Active\",\"msdyn_status@ufx-logicalname\":\"msdyn_requirementstatus\",\"msdyn_sortoptions\":\"random\",\"msdyn_istemplate\":false,\"msdyn_istemplate@ufx-formatvalue\":\"No\",\"msdyn_allocationmethod\":192350000,\"msdyn_allocationmethod@ufx-type\":\"option\",\"msdyn_allocationmethod@ufx-formatvalue\":\"None\",\"createdby\":\"56262a4d-805a-ea11-a81d-000d3aaa5cbe\",\"createdby@ufx-type\":\"lookup\",\"createdby@ufx-formatvalue\":\"First name Last name\",\"createdby@ufx-logicalname\":\"systemuser\",\"owningbusinessunit\":\"641f2a4d-805a-ea11-a81d-000d3aaa5cbe\",\"owningbusinessunit@ufx-type\":\"lookup\",\"owningbusinessunit@ufx-logicalname\":\"businessunit\",\"msdyn_fromdate\":\"2020-03-01T00:00:00Z\",\"msdyn_fromdate@ufx-type\":\"datetime\",\"msdyn_fromdate@ufx-formatvalue\":\"3/1/2020\",\"owninguser\":\"56262a4d-805a-ea11-a81d-000d3aaa5cbe\",\"owninguser@ufx-type\":\"lookup\",\"owninguser@ufx-logicalname\":\"systemuser\",\"msdyn_serviceappointment\":\"f770ddb1-da5d-ea11-a81e-000d3aaa5cbe\",\"msdyn_serviceappointment@ufx-type\":\"lookup\",\"msdyn_serviceappointment@ufx-formatvalue\":\"Doc SA1\",\"msdyn_serviceappointment@ufx-logicalname\":\"serviceappointment\",\"msdyn_duration\":60,\"msdyn_duration@ufx-type\":\"int\",\"msdyn_duration@ufx-formatvalue\":\"60\",\"InitialWorkLocation\":690970000,\"InitialWorkLocation@ufx-type\":\"option\",\"InitialWorkLocation@ufx-formatvalue\":\"Onsite\",\"AllowOverlapping\":false,\"IgnoreTravelTime\":false,\"IgnoreDuration\":false,\"RealTimeMode\":false,\"Radius\":20,\"Radius@ufx-type\":\"int\",\"IgnoreProposedBookings\":true},\"ResourceTypes\":[{\"option\":2,\"option@ufx-type\":\"option\"},{\"option\":3,\"option@ufx-type\":\"option\"},{\"option\":4,\"option@ufx-type\":\"option\"},{\"option\":5,\"option@ufx-type\":\"option\"},{\"option\":6,\"option@ufx-type\":\"option\"},{\"option\":7,\"option@ufx-type\":\"option\"},{\"option\":8,\"option@ufx-type\":\"option\"}],\"PreferredResources\":[{\"@ufx-id\":\"34d67b43-8160-4573-b815-9ae24cd4d905\",\"@ufx-logicalname\":\"bookableresource\",\"@ufx-formatvalue\":\"Bldg 1 Room 306 @442\"},{\"@ufx-id\":\"ebb71951-70a6-4f47-8ebb-7ed66e95ef8d\",\"@ufx-logicalname\":\"bookableresource\",\"@ufx-formatvalue\":\"Tech-DVS 442 Room 306\"},{\"@ufx-id\":\"ebb71951-70a6-4f47-8ebb-7ed66e95ef8d\",\"@ufx-logicalname\":\"bookableresource\",\"@ufx-formatvalue\":\"Tech-DVS 442 Room 306\"},{\"@ufx-id\":\"12b9693b-793b-45b6-abd8-236ed0831ce5\",\"@ufx-logicalname\":\"bookableresource\",\"@ufx-formatvalue\":\"Test Clinic @442\"},{\"@ufx-id\":\"34d67b43-8160-4573-b815-9ae24cd4d905\",\"@ufx-logicalname\":\"bookableresource\",\"@ufx-formatvalue\":\"Bldg 1 Room 306 @442\"},{\"@ufx-id\":\"12b9693b-793b-45b6-abd8-236ed0831ce5\",\"@ufx-logicalname\":\"bookableresource\",\"@ufx-formatvalue\":\"Test Clinic @442\"}]}"
              },
              {
                "Key": "Resources",
                "Value": {
                  "Entities": [
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "result",
                          "Value": {
                            "Id": "34d67b43-8160-4573-b815-9ae24cd4d905",
                            "LogicalName": "bookableresource",
                            "Name": null,
                            "KeyAttributes": [],
                            "RowVersion": null
                          }
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "result",
                          "Value": {
                            "Id": "ebb71951-70a6-4f47-8ebb-7ed66e95ef8d",
                            "LogicalName": "bookableresource",
                            "Name": null,
                            "KeyAttributes": [],
                            "RowVersion": null
                          }
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "result",
                          "Value": {
                            "Id": "12b9693b-793b-45b6-abd8-236ed0831ce5",
                            "LogicalName": "bookableresource",
                            "Name": null,
                            "KeyAttributes": [],
                            "RowVersion": null
                          }
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "result",
                          "Value": {
                            "Id": "cb69fd6f-3091-433a-bb14-20c0b542a581",
                            "LogicalName": "bookableresource",
                            "Name": null,
                            "KeyAttributes": [],
                            "RowVersion": null
                          }
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "result",
                          "Value": {
                            "Id": "69f8d921-10c7-4d6f-8bca-3345d36b21ca",
                            "LogicalName": "bookableresource",
                            "Name": null,
                            "KeyAttributes": [],
                            "RowVersion": null
                          }
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "result",
                          "Value": {
                            "Id": "15722b27-facb-45e6-b262-afb30ed29382",
                            "LogicalName": "bookableresource",
                            "Name": null,
                            "KeyAttributes": [],
                            "RowVersion": null
                          }
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "result",
                          "Value": {
                            "Id": "b2d3bc55-9c75-4447-ba7c-5336bd081cb1",
                            "LogicalName": "bookableresource",
                            "Name": null,
                            "KeyAttributes": [],
                            "RowVersion": null
                          }
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "result",
                          "Value": {
                            "Id": "d8e264aa-af93-49ed-89e8-321e3a1d4abf",
                            "LogicalName": "bookableresource",
                            "Name": null,
                            "KeyAttributes": [],
                            "RowVersion": null
                          }
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "result",
                          "Value": {
                            "Id": "bc095d77-fa68-4fa7-b80a-fcfb0fd32087",
                            "LogicalName": "bookableresource",
                            "Name": null,
                            "KeyAttributes": [],
                            "RowVersion": null
                          }
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "result",
                          "Value": {
                            "Id": "6116cec7-e4ad-4d25-aa67-6aa029bcc30b",
                            "LogicalName": "bookableresource",
                            "Name": null,
                            "KeyAttributes": [],
                            "RowVersion": null
                          }
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "result",
                          "Value": {
                            "Id": "a0fd36d1-dcb0-41d1-968d-c5fa214702e7",
                            "LogicalName": "bookableresource",
                            "Name": null,
                            "KeyAttributes": [],
                            "RowVersion": null
                          }
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "result",
                          "Value": {
                            "Id": "d97e6f62-ed34-4bbd-864e-e3f5b3e824cf",
                            "LogicalName": "bookableresource",
                            "Name": null,
                            "KeyAttributes": [],
                            "RowVersion": null
                          }
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "result",
                          "Value": {
                            "Id": "617ec1ab-6e05-455b-a125-dab6f472106a",
                            "LogicalName": "bookableresource",
                            "Name": null,
                            "KeyAttributes": [],
                            "RowVersion": null
                          }
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "result",
                          "Value": {
                            "Id": "26592224-35eb-4215-b990-1d7f561d7edd",
                            "LogicalName": "bookableresource",
                            "Name": null,
                            "KeyAttributes": [],
                            "RowVersion": null
                          }
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "result",
                          "Value": {
                            "Id": "59178960-dca6-41fd-9681-c252a12d166e",
                            "LogicalName": "bookableresource",
                            "Name": null,
                            "KeyAttributes": [],
                            "RowVersion": null
                          }
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "result",
                          "Value": {
                            "Id": "62fd4fce-1f1e-4835-915e-fe67201234a2",
                            "LogicalName": "bookableresource",
                            "Name": null,
                            "KeyAttributes": [],
                            "RowVersion": null
                          }
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "result",
                          "Value": {
                            "Id": "156be26c-fe0c-45c5-b1ed-591cb92f17a7",
                            "LogicalName": "bookableresource",
                            "Name": null,
                            "KeyAttributes": [],
                            "RowVersion": null
                          }
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    }
                  ],
                  "MoreRecords": false,
                  "PagingCookie": null,
                  "MinActiveRowVersion": "",
                  "TotalRecordCount": 0,
                  "TotalRecordCountLimitExceeded": false,
                  "EntityName": "organization"
                }
              }
            ],
            "EntityState": null,
            "FormattedValues": [],
            "RelatedEntities": [],
            "RowVersion": null,
            "KeyAttributes": []
          },
          {
            "LogicalName": "organization",
            "Id": "00000000-0000-0000-0000-000000000000",
            "Attributes": [
              {
                "Key": "Requirement",
                "Value": {
                  "Id": "6583cfba-e0d7-4997-b651-88f39c7edb94",
                  "LogicalName": "msdyn_resourcerequirement",
                  "Name": null,
                  "KeyAttributes": [],
                  "RowVersion": null
                }
              },
              {
                "Key": "ConstraintBag",
                "Value": "{\"@ufx-logicalname\":\"msdyn_resourcerequirement\",\"Requirement\":{\"@ufx-id\":\"6583cfba-e0d7-4997-b651-88f39c7edb94\",\"@ufx-logicalname\":\"msdyn_resourcerequirement\",\"msdyn_templaterequirementid\":\"0ED67B3A-ABCC-4CAD-965B-BC98E9A78C53\",\"statecode\":0,\"statecode@ufx-type\":\"option\",\"statecode@ufx-formatvalue\":\"Active\",\"msdyn_requirementgroupid\":\"6927721a-0137-42be-8092-26995625a9d9\",\"msdyn_requirementgroupid@ufx-type\":\"lookup\",\"msdyn_requirementgroupid@ufx-formatvalue\":\"Doc SA1\",\"msdyn_requirementgroupid@ufx-logicalname\":\"msdyn_requirementgroup\",\"statuscode\":1,\"statuscode@ufx-type\":\"option\",\"statuscode@ufx-formatvalue\":\"Active\",\"msdyn_interval\":15,\"msdyn_interval@ufx-type\":\"int\",\"msdyn_interval@ufx-formatvalue\":\"15\",\"createdon\":\"2020-03-04T05:40:46Z\",\"createdon@ufx-type\":\"datetime\",\"createdon@ufx-formatvalue\":\"3/4/2020 5:40 AM\",\"msdyn_worklocation\":690970000,\"msdyn_worklocation@ufx-type\":\"option\",\"msdyn_worklocation@ufx-formatvalue\":\"Onsite\",\"msdyn_bookingsetupmetadataid\":\"651bd1e8-3a04-41a3-927c-aa1a71080293\",\"msdyn_bookingsetupmetadataid@ufx-type\":\"lookup\",\"msdyn_bookingsetupmetadataid@ufx-formatvalue\":\"serviceappointment\",\"msdyn_bookingsetupmetadataid@ufx-logicalname\":\"msdyn_bookingsetupmetadata\",\"msdyn_timegroup\":\"41c70d4a-919e-4d77-b5ed-d234977cab58\",\"msdyn_timegroup@ufx-type\":\"lookup\",\"msdyn_timegroup@ufx-formatvalue\":\"1 Service Individual Resources\",\"msdyn_timegroup@ufx-logicalname\":\"msdyn_timegroup\",\"ownerid\":\"56262a4d-805a-ea11-a81d-000d3aaa5cbe\",\"ownerid@ufx-type\":\"lookup\",\"ownerid@ufx-formatvalue\":\"First name Last name\",\"ownerid@ufx-logicalname\":\"systemuser\",\"msdyn_requirementgroupcontrolviewid\":\"1\",\"modifiedon\":\"2020-03-09T06:44:47Z\",\"modifiedon@ufx-type\":\"datetime\",\"modifiedon@ufx-formatvalue\":\"3/9/2020 6:44 AM\",\"msdyn_todate\":\"2020-04-25T23:59:00Z\",\"msdyn_todate@ufx-type\":\"datetime\",\"msdyn_todate@ufx-formatvalue\":\"4/25/2020\",\"msdyn_requirementrelationshipid\":\"85aee02f-57ee-4de5-a887-dff91d8e63dd\",\"msdyn_requirementrelationshipid@ufx-type\":\"lookup\",\"msdyn_requirementrelationshipid@ufx-formatvalue\":\"1 Service Individual Resources\",\"msdyn_requirementrelationshipid@ufx-logicalname\":\"msdyn_requirementrelationship\",\"msdyn_name\":\"New Resource Requirement\",\"timezoneruleversionnumber\":4,\"timezoneruleversionnumber@ufx-type\":\"int\",\"timezoneruleversionnumber@ufx-formatvalue\":\"4\",\"msdyn_effort\":1.0000000000,\"msdyn_effort@ufx-type\":\"decimal\",\"msdyn_effort@ufx-formatvalue\":\"1.0000\",\"msdyn_isprimary\":false,\"msdyn_isprimary@ufx-formatvalue\":\"No\",\"msdyn_resourcerequirementid\":\"6583cfba-e0d7-4997-b651-88f39c7edb94\",\"msdyn_resourcerequirementid@ufx-type\":\"guid\",\"modifiedby\":\"56262a4d-805a-ea11-a81d-000d3aaa5cbe\",\"modifiedby@ufx-type\":\"lookup\",\"modifiedby@ufx-formatvalue\":\"First name Last name\",\"modifiedby@ufx-logicalname\":\"systemuser\",\"msdyn_status\":\"f1f20cae-4a76-44eb-be6d-db346ba57013\",\"msdyn_status@ufx-type\":\"lookup\",\"msdyn_status@ufx-formatvalue\":\"Active\",\"msdyn_status@ufx-logicalname\":\"msdyn_requirementstatus\",\"msdyn_sortoptions\":\"random\",\"msdyn_istemplate\":false,\"msdyn_istemplate@ufx-formatvalue\":\"No\",\"msdyn_allocationmethod\":192350000,\"msdyn_allocationmethod@ufx-type\":\"option\",\"msdyn_allocationmethod@ufx-formatvalue\":\"None\",\"createdby\":\"56262a4d-805a-ea11-a81d-000d3aaa5cbe\",\"createdby@ufx-type\":\"lookup\",\"createdby@ufx-formatvalue\":\"First name Last name\",\"createdby@ufx-logicalname\":\"systemuser\",\"owningbusinessunit\":\"641f2a4d-805a-ea11-a81d-000d3aaa5cbe\",\"owningbusinessunit@ufx-type\":\"lookup\",\"owningbusinessunit@ufx-logicalname\":\"businessunit\",\"msdyn_fromdate\":\"2020-03-01T00:00:00Z\",\"msdyn_fromdate@ufx-type\":\"datetime\",\"msdyn_fromdate@ufx-formatvalue\":\"3/1/2020\",\"owninguser\":\"56262a4d-805a-ea11-a81d-000d3aaa5cbe\",\"owninguser@ufx-type\":\"lookup\",\"owninguser@ufx-logicalname\":\"systemuser\",\"msdyn_serviceappointment\":\"f770ddb1-da5d-ea11-a81e-000d3aaa5cbe\",\"msdyn_serviceappointment@ufx-type\":\"lookup\",\"msdyn_serviceappointment@ufx-formatvalue\":\"Doc SA1\",\"msdyn_serviceappointment@ufx-logicalname\":\"serviceappointment\",\"msdyn_duration\":60,\"msdyn_duration@ufx-type\":\"int\",\"msdyn_duration@ufx-formatvalue\":\"60\",\"InitialWorkLocation\":690970000,\"InitialWorkLocation@ufx-type\":\"option\",\"InitialWorkLocation@ufx-formatvalue\":\"Onsite\",\"AllowOverlapping\":false,\"IgnoreTravelTime\":false,\"IgnoreDuration\":false,\"RealTimeMode\":false,\"Radius\":20,\"Radius@ufx-type\":\"int\",\"IgnoreProposedBookings\":true},\"ResourceTypes\":[{\"option\":2,\"option@ufx-type\":\"option\"},{\"option\":3,\"option@ufx-type\":\"option\"},{\"option\":4,\"option@ufx-type\":\"option\"},{\"option\":5,\"option@ufx-type\":\"option\"},{\"option\":6,\"option@ufx-type\":\"option\"},{\"option\":7,\"option@ufx-type\":\"option\"},{\"option\":8,\"option@ufx-type\":\"option\"}],\"PreferredResources\":[{\"@ufx-id\":\"34d67b43-8160-4573-b815-9ae24cd4d905\",\"@ufx-logicalname\":\"bookableresource\",\"@ufx-formatvalue\":\"Bldg 1 Room 306 @442\"},{\"@ufx-id\":\"34d67b43-8160-4573-b815-9ae24cd4d905\",\"@ufx-logicalname\":\"bookableresource\",\"@ufx-formatvalue\":\"Bldg 1 Room 306 @442\"},{\"@ufx-id\":\"ebb71951-70a6-4f47-8ebb-7ed66e95ef8d\",\"@ufx-logicalname\":\"bookableresource\",\"@ufx-formatvalue\":\"Tech-DVS 442 Room 306\"},{\"@ufx-id\":\"12b9693b-793b-45b6-abd8-236ed0831ce5\",\"@ufx-logicalname\":\"bookableresource\",\"@ufx-formatvalue\":\"Test Clinic @442\"},{\"@ufx-id\":\"34d67b43-8160-4573-b815-9ae24cd4d905\",\"@ufx-logicalname\":\"bookableresource\",\"@ufx-formatvalue\":\"Bldg 1 Room 306 @442\"},{\"@ufx-id\":\"12b9693b-793b-45b6-abd8-236ed0831ce5\",\"@ufx-logicalname\":\"bookableresource\",\"@ufx-formatvalue\":\"Test Clinic @442\"},{\"@ufx-id\":\"ebb71951-70a6-4f47-8ebb-7ed66e95ef8d\",\"@ufx-logicalname\":\"bookableresource\",\"@ufx-formatvalue\":\"Tech-DVS 442 Room 306\"},{\"@ufx-id\":\"12b9693b-793b-45b6-abd8-236ed0831ce5\",\"@ufx-logicalname\":\"bookableresource\",\"@ufx-formatvalue\":\"Test Clinic @442\"},{\"@ufx-id\":\"ebb71951-70a6-4f47-8ebb-7ed66e95ef8d\",\"@ufx-logicalname\":\"bookableresource\",\"@ufx-formatvalue\":\"Tech-DVS 442 Room 306\"}]}"
              },
              {
                "Key": "Resources",
                "Value": {
                  "Entities": [
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "result",
                          "Value": {
                            "Id": "34d67b43-8160-4573-b815-9ae24cd4d905",
                            "LogicalName": "bookableresource",
                            "Name": null,
                            "KeyAttributes": [],
                            "RowVersion": null
                          }
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "result",
                          "Value": {
                            "Id": "ebb71951-70a6-4f47-8ebb-7ed66e95ef8d",
                            "LogicalName": "bookableresource",
                            "Name": null,
                            "KeyAttributes": [],
                            "RowVersion": null
                          }
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "result",
                          "Value": {
                            "Id": "12b9693b-793b-45b6-abd8-236ed0831ce5",
                            "LogicalName": "bookableresource",
                            "Name": null,
                            "KeyAttributes": [],
                            "RowVersion": null
                          }
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "result",
                          "Value": {
                            "Id": "cb69fd6f-3091-433a-bb14-20c0b542a581",
                            "LogicalName": "bookableresource",
                            "Name": null,
                            "KeyAttributes": [],
                            "RowVersion": null
                          }
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "result",
                          "Value": {
                            "Id": "69f8d921-10c7-4d6f-8bca-3345d36b21ca",
                            "LogicalName": "bookableresource",
                            "Name": null,
                            "KeyAttributes": [],
                            "RowVersion": null
                          }
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "result",
                          "Value": {
                            "Id": "15722b27-facb-45e6-b262-afb30ed29382",
                            "LogicalName": "bookableresource",
                            "Name": null,
                            "KeyAttributes": [],
                            "RowVersion": null
                          }
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "result",
                          "Value": {
                            "Id": "b2d3bc55-9c75-4447-ba7c-5336bd081cb1",
                            "LogicalName": "bookableresource",
                            "Name": null,
                            "KeyAttributes": [],
                            "RowVersion": null
                          }
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "result",
                          "Value": {
                            "Id": "d8e264aa-af93-49ed-89e8-321e3a1d4abf",
                            "LogicalName": "bookableresource",
                            "Name": null,
                            "KeyAttributes": [],
                            "RowVersion": null
                          }
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "result",
                          "Value": {
                            "Id": "bc095d77-fa68-4fa7-b80a-fcfb0fd32087",
                            "LogicalName": "bookableresource",
                            "Name": null,
                            "KeyAttributes": [],
                            "RowVersion": null
                          }
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "result",
                          "Value": {
                            "Id": "6116cec7-e4ad-4d25-aa67-6aa029bcc30b",
                            "LogicalName": "bookableresource",
                            "Name": null,
                            "KeyAttributes": [],
                            "RowVersion": null
                          }
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "result",
                          "Value": {
                            "Id": "a0fd36d1-dcb0-41d1-968d-c5fa214702e7",
                            "LogicalName": "bookableresource",
                            "Name": null,
                            "KeyAttributes": [],
                            "RowVersion": null
                          }
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "result",
                          "Value": {
                            "Id": "d97e6f62-ed34-4bbd-864e-e3f5b3e824cf",
                            "LogicalName": "bookableresource",
                            "Name": null,
                            "KeyAttributes": [],
                            "RowVersion": null
                          }
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "result",
                          "Value": {
                            "Id": "617ec1ab-6e05-455b-a125-dab6f472106a",
                            "LogicalName": "bookableresource",
                            "Name": null,
                            "KeyAttributes": [],
                            "RowVersion": null
                          }
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "result",
                          "Value": {
                            "Id": "26592224-35eb-4215-b990-1d7f561d7edd",
                            "LogicalName": "bookableresource",
                            "Name": null,
                            "KeyAttributes": [],
                            "RowVersion": null
                          }
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "result",
                          "Value": {
                            "Id": "59178960-dca6-41fd-9681-c252a12d166e",
                            "LogicalName": "bookableresource",
                            "Name": null,
                            "KeyAttributes": [],
                            "RowVersion": null
                          }
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "result",
                          "Value": {
                            "Id": "62fd4fce-1f1e-4835-915e-fe67201234a2",
                            "LogicalName": "bookableresource",
                            "Name": null,
                            "KeyAttributes": [],
                            "RowVersion": null
                          }
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "result",
                          "Value": {
                            "Id": "156be26c-fe0c-45c5-b1ed-591cb92f17a7",
                            "LogicalName": "bookableresource",
                            "Name": null,
                            "KeyAttributes": [],
                            "RowVersion": null
                          }
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    }
                  ],
                  "MoreRecords": false,
                  "PagingCookie": null,
                  "MinActiveRowVersion": "",
                  "TotalRecordCount": 0,
                  "TotalRecordCountLimitExceeded": false,
                  "EntityName": "organization"
                }
              }
            ],
            "EntityState": null,
            "FormattedValues": [],
            "RelatedEntities": [],
            "RowVersion": null,
            "KeyAttributes": []
          },
          {
            "LogicalName": "organization",
            "Id": "00000000-0000-0000-0000-000000000000",
            "Attributes": [
              {
                "Key": "Requirement",
                "Value": {
                  "Id": "d64da763-c73e-4990-897c-f3293b731ced",
                  "LogicalName": "msdyn_resourcerequirement",
                  "Name": null,
                  "KeyAttributes": [],
                  "RowVersion": null
                }
              },
              {
                "Key": "ConstraintBag",
                "Value": "{\"@ufx-logicalname\":\"msdyn_resourcerequirement\",\"Requirement\":{\"@ufx-id\":\"d64da763-c73e-4990-897c-f3293b731ced\",\"@ufx-logicalname\":\"msdyn_resourcerequirement\",\"msdyn_templaterequirementid\":\"E203D7E6-95B8-486D-B8DF-00DC19312D5F\",\"statecode\":0,\"statecode@ufx-type\":\"option\",\"statecode@ufx-formatvalue\":\"Active\",\"msdyn_requirementgroupid\":\"6927721a-0137-42be-8092-26995625a9d9\",\"msdyn_requirementgroupid@ufx-type\":\"lookup\",\"msdyn_requirementgroupid@ufx-formatvalue\":\"Doc SA1\",\"msdyn_requirementgroupid@ufx-logicalname\":\"msdyn_requirementgroup\",\"statuscode\":1,\"statuscode@ufx-type\":\"option\",\"statuscode@ufx-formatvalue\":\"Active\",\"msdyn_interval\":15,\"msdyn_interval@ufx-type\":\"int\",\"msdyn_interval@ufx-formatvalue\":\"15\",\"createdon\":\"2020-03-04T05:40:46Z\",\"createdon@ufx-type\":\"datetime\",\"createdon@ufx-formatvalue\":\"3/4/2020 5:40 AM\",\"msdyn_worklocation\":690970000,\"msdyn_worklocation@ufx-type\":\"option\",\"msdyn_worklocation@ufx-formatvalue\":\"Onsite\",\"msdyn_bookingsetupmetadataid\":\"651bd1e8-3a04-41a3-927c-aa1a71080293\",\"msdyn_bookingsetupmetadataid@ufx-type\":\"lookup\",\"msdyn_bookingsetupmetadataid@ufx-formatvalue\":\"serviceappointment\",\"msdyn_bookingsetupmetadataid@ufx-logicalname\":\"msdyn_bookingsetupmetadata\",\"msdyn_timegroup\":\"41c70d4a-919e-4d77-b5ed-d234977cab58\",\"msdyn_timegroup@ufx-type\":\"lookup\",\"msdyn_timegroup@ufx-formatvalue\":\"1 Service Individual Resources\",\"msdyn_timegroup@ufx-logicalname\":\"msdyn_timegroup\",\"ownerid\":\"56262a4d-805a-ea11-a81d-000d3aaa5cbe\",\"ownerid@ufx-type\":\"lookup\",\"ownerid@ufx-formatvalue\":\"First name Last name\",\"ownerid@ufx-logicalname\":\"systemuser\",\"msdyn_requirementgroupcontrolviewid\":\"2\",\"modifiedon\":\"2020-03-09T06:44:48Z\",\"modifiedon@ufx-type\":\"datetime\",\"modifiedon@ufx-formatvalue\":\"3/9/2020 6:44 AM\",\"msdyn_todate\":\"2020-04-25T23:59:00Z\",\"msdyn_todate@ufx-type\":\"datetime\",\"msdyn_todate@ufx-formatvalue\":\"4/25/2020\",\"msdyn_requirementrelationshipid\":\"85aee02f-57ee-4de5-a887-dff91d8e63dd\",\"msdyn_requirementrelationshipid@ufx-type\":\"lookup\",\"msdyn_requirementrelationshipid@ufx-formatvalue\":\"1 Service Individual Resources\",\"msdyn_requirementrelationshipid@ufx-logicalname\":\"msdyn_requirementrelationship\",\"msdyn_name\":\"New Resource Requirement\",\"timezoneruleversionnumber\":4,\"timezoneruleversionnumber@ufx-type\":\"int\",\"timezoneruleversionnumber@ufx-formatvalue\":\"4\",\"msdyn_effort\":1.0000000000,\"msdyn_effort@ufx-type\":\"decimal\",\"msdyn_effort@ufx-formatvalue\":\"1.0000\",\"msdyn_isprimary\":true,\"msdyn_isprimary@ufx-formatvalue\":\"Yes\",\"msdyn_resourcerequirementid\":\"d64da763-c73e-4990-897c-f3293b731ced\",\"msdyn_resourcerequirementid@ufx-type\":\"guid\",\"modifiedby\":\"56262a4d-805a-ea11-a81d-000d3aaa5cbe\",\"modifiedby@ufx-type\":\"lookup\",\"modifiedby@ufx-formatvalue\":\"First name Last name\",\"modifiedby@ufx-logicalname\":\"systemuser\",\"msdyn_status\":\"f1f20cae-4a76-44eb-be6d-db346ba57013\",\"msdyn_status@ufx-type\":\"lookup\",\"msdyn_status@ufx-formatvalue\":\"Active\",\"msdyn_status@ufx-logicalname\":\"msdyn_requirementstatus\",\"msdyn_sortoptions\":\"random\",\"msdyn_istemplate\":false,\"msdyn_istemplate@ufx-formatvalue\":\"No\",\"msdyn_allocationmethod\":192350000,\"msdyn_allocationmethod@ufx-type\":\"option\",\"msdyn_allocationmethod@ufx-formatvalue\":\"None\",\"createdby\":\"56262a4d-805a-ea11-a81d-000d3aaa5cbe\",\"createdby@ufx-type\":\"lookup\",\"createdby@ufx-formatvalue\":\"First name Last name\",\"createdby@ufx-logicalname\":\"systemuser\",\"owningbusinessunit\":\"641f2a4d-805a-ea11-a81d-000d3aaa5cbe\",\"owningbusinessunit@ufx-type\":\"lookup\",\"owningbusinessunit@ufx-logicalname\":\"businessunit\",\"msdyn_fromdate\":\"2020-03-01T00:00:00Z\",\"msdyn_fromdate@ufx-type\":\"datetime\",\"msdyn_fromdate@ufx-formatvalue\":\"3/1/2020\",\"owninguser\":\"56262a4d-805a-ea11-a81d-000d3aaa5cbe\",\"owninguser@ufx-type\":\"lookup\",\"owninguser@ufx-logicalname\":\"systemuser\",\"msdyn_serviceappointment\":\"f770ddb1-da5d-ea11-a81e-000d3aaa5cbe\",\"msdyn_serviceappointment@ufx-type\":\"lookup\",\"msdyn_serviceappointment@ufx-formatvalue\":\"Doc SA1\",\"msdyn_serviceappointment@ufx-logicalname\":\"serviceappointment\",\"msdyn_duration\":60,\"msdyn_duration@ufx-type\":\"int\",\"msdyn_duration@ufx-formatvalue\":\"60\",\"InitialWorkLocation\":690970000,\"InitialWorkLocation@ufx-type\":\"option\",\"InitialWorkLocation@ufx-formatvalue\":\"Onsite\",\"AllowOverlapping\":false,\"IgnoreTravelTime\":false,\"IgnoreDuration\":false,\"RealTimeMode\":false,\"Radius\":20,\"Radius@ufx-type\":\"int\",\"IgnoreProposedBookings\":true},\"ResourceTypes\":[{\"option\":2,\"option@ufx-type\":\"option\"},{\"option\":3,\"option@ufx-type\":\"option\"},{\"option\":4,\"option@ufx-type\":\"option\"},{\"option\":5,\"option@ufx-type\":\"option\"},{\"option\":6,\"option@ufx-type\":\"option\"},{\"option\":7,\"option@ufx-type\":\"option\"},{\"option\":8,\"option@ufx-type\":\"option\"}],\"PreferredResources\":[{\"@ufx-id\":\"34d67b43-8160-4573-b815-9ae24cd4d905\",\"@ufx-logicalname\":\"bookableresource\",\"@ufx-formatvalue\":\"Bldg 1 Room 306 @442\"},{\"@ufx-id\":\"12b9693b-793b-45b6-abd8-236ed0831ce5\",\"@ufx-logicalname\":\"bookableresource\",\"@ufx-formatvalue\":\"Test Clinic @442\"},{\"@ufx-id\":\"ebb71951-70a6-4f47-8ebb-7ed66e95ef8d\",\"@ufx-logicalname\":\"bookableresource\",\"@ufx-formatvalue\":\"Tech-DVS 442 Room 306\"}]}"
              },
              {
                "Key": "Resources",
                "Value": {
                  "Entities": [
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "result",
                          "Value": {
                            "Id": "34d67b43-8160-4573-b815-9ae24cd4d905",
                            "LogicalName": "bookableresource",
                            "Name": null,
                            "KeyAttributes": [],
                            "RowVersion": null
                          }
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "result",
                          "Value": {
                            "Id": "ebb71951-70a6-4f47-8ebb-7ed66e95ef8d",
                            "LogicalName": "bookableresource",
                            "Name": null,
                            "KeyAttributes": [],
                            "RowVersion": null
                          }
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "result",
                          "Value": {
                            "Id": "12b9693b-793b-45b6-abd8-236ed0831ce5",
                            "LogicalName": "bookableresource",
                            "Name": null,
                            "KeyAttributes": [],
                            "RowVersion": null
                          }
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "result",
                          "Value": {
                            "Id": "cb69fd6f-3091-433a-bb14-20c0b542a581",
                            "LogicalName": "bookableresource",
                            "Name": null,
                            "KeyAttributes": [],
                            "RowVersion": null
                          }
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "result",
                          "Value": {
                            "Id": "69f8d921-10c7-4d6f-8bca-3345d36b21ca",
                            "LogicalName": "bookableresource",
                            "Name": null,
                            "KeyAttributes": [],
                            "RowVersion": null
                          }
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "result",
                          "Value": {
                            "Id": "15722b27-facb-45e6-b262-afb30ed29382",
                            "LogicalName": "bookableresource",
                            "Name": null,
                            "KeyAttributes": [],
                            "RowVersion": null
                          }
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "result",
                          "Value": {
                            "Id": "b2d3bc55-9c75-4447-ba7c-5336bd081cb1",
                            "LogicalName": "bookableresource",
                            "Name": null,
                            "KeyAttributes": [],
                            "RowVersion": null
                          }
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "result",
                          "Value": {
                            "Id": "d8e264aa-af93-49ed-89e8-321e3a1d4abf",
                            "LogicalName": "bookableresource",
                            "Name": null,
                            "KeyAttributes": [],
                            "RowVersion": null
                          }
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "result",
                          "Value": {
                            "Id": "bc095d77-fa68-4fa7-b80a-fcfb0fd32087",
                            "LogicalName": "bookableresource",
                            "Name": null,
                            "KeyAttributes": [],
                            "RowVersion": null
                          }
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "result",
                          "Value": {
                            "Id": "6116cec7-e4ad-4d25-aa67-6aa029bcc30b",
                            "LogicalName": "bookableresource",
                            "Name": null,
                            "KeyAttributes": [],
                            "RowVersion": null
                          }
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "result",
                          "Value": {
                            "Id": "a0fd36d1-dcb0-41d1-968d-c5fa214702e7",
                            "LogicalName": "bookableresource",
                            "Name": null,
                            "KeyAttributes": [],
                            "RowVersion": null
                          }
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "result",
                          "Value": {
                            "Id": "d97e6f62-ed34-4bbd-864e-e3f5b3e824cf",
                            "LogicalName": "bookableresource",
                            "Name": null,
                            "KeyAttributes": [],
                            "RowVersion": null
                          }
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "result",
                          "Value": {
                            "Id": "617ec1ab-6e05-455b-a125-dab6f472106a",
                            "LogicalName": "bookableresource",
                            "Name": null,
                            "KeyAttributes": [],
                            "RowVersion": null
                          }
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "result",
                          "Value": {
                            "Id": "26592224-35eb-4215-b990-1d7f561d7edd",
                            "LogicalName": "bookableresource",
                            "Name": null,
                            "KeyAttributes": [],
                            "RowVersion": null
                          }
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "result",
                          "Value": {
                            "Id": "59178960-dca6-41fd-9681-c252a12d166e",
                            "LogicalName": "bookableresource",
                            "Name": null,
                            "KeyAttributes": [],
                            "RowVersion": null
                          }
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "result",
                          "Value": {
                            "Id": "62fd4fce-1f1e-4835-915e-fe67201234a2",
                            "LogicalName": "bookableresource",
                            "Name": null,
                            "KeyAttributes": [],
                            "RowVersion": null
                          }
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "result",
                          "Value": {
                            "Id": "156be26c-fe0c-45c5-b1ed-591cb92f17a7",
                            "LogicalName": "bookableresource",
                            "Name": null,
                            "KeyAttributes": [],
                            "RowVersion": null
                          }
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    }
                  ],
                  "MoreRecords": false,
                  "PagingCookie": null,
                  "MinActiveRowVersion": "",
                  "TotalRecordCount": 0,
                  "TotalRecordCountLimitExceeded": false,
                  "EntityName": "organization"
                }
              }
            ],
            "EntityState": null,
            "FormattedValues": [],
            "RelatedEntities": [],
            "RowVersion": null,
            "KeyAttributes": []
          }
        ],
        "MoreRecords": false,
        "PagingCookie": null,
        "MinActiveRowVersion": "",
        "TotalRecordCount": 0,
        "TotalRecordCountLimitExceeded": false,
        "EntityName": "organization"
      }
    },
    {
      "Key": "ProposalResourceAssignmentSets",
      "Value": {
        "Entities": [
          {
            "LogicalName": "organization",
            "Id": "00000000-0000-0000-0000-000000000000",
            "Attributes": [
              {
                "Key": "IntervalStart",
                "Value": "2020-03-09T08:15:00Z"
              },
              {
                "Key": "ProposalResourceAssignments",
                "Value": {
                  "Entities": [
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "RequirementId",
                          "Value": "d64da763-c73e-4990-897c-f3293b731ced"
                        },
                        {
                          "Key": "ResourceId",
                          "Value": "34d67b43-8160-4573-b815-9ae24cd4d905"
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "RequirementId",
                          "Value": "6583cfba-e0d7-4997-b651-88f39c7edb94"
                        },
                        {
                          "Key": "ResourceId",
                          "Value": "d8e264aa-af93-49ed-89e8-321e3a1d4abf"
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "RequirementId",
                          "Value": "a80e4368-64d4-4d50-954c-0e6d8d7b8fb1"
                        },
                        {
                          "Key": "ResourceId",
                          "Value": "15722b27-facb-45e6-b262-afb30ed29382"
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    }
                  ],
                  "MoreRecords": false,
                  "PagingCookie": null,
                  "MinActiveRowVersion": "",
                  "TotalRecordCount": 0,
                  "TotalRecordCountLimitExceeded": false,
                  "EntityName": "organization"
                }
              }
            ],
            "EntityState": null,
            "FormattedValues": [],
            "RelatedEntities": [],
            "RowVersion": null,
            "KeyAttributes": []
          },
          {
            "LogicalName": "organization",
            "Id": "00000000-0000-0000-0000-000000000000",
            "Attributes": [
              {
                "Key": "IntervalStart",
                "Value": "2020-03-09T08:30:00Z"
              },
              {
                "Key": "ProposalResourceAssignments",
                "Value": {
                  "Entities": [
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "RequirementId",
                          "Value": "d64da763-c73e-4990-897c-f3293b731ced"
                        },
                        {
                          "Key": "ResourceId",
                          "Value": "69f8d921-10c7-4d6f-8bca-3345d36b21ca"
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "RequirementId",
                          "Value": "6583cfba-e0d7-4997-b651-88f39c7edb94"
                        },
                        {
                          "Key": "ResourceId",
                          "Value": "26592224-35eb-4215-b990-1d7f561d7edd"
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "RequirementId",
                          "Value": "a80e4368-64d4-4d50-954c-0e6d8d7b8fb1"
                        },
                        {
                          "Key": "ResourceId",
                          "Value": "617ec1ab-6e05-455b-a125-dab6f472106a"
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    }
                  ],
                  "MoreRecords": false,
                  "PagingCookie": null,
                  "MinActiveRowVersion": "",
                  "TotalRecordCount": 0,
                  "TotalRecordCountLimitExceeded": false,
                  "EntityName": "organization"
                }
              }
            ],
            "EntityState": null,
            "FormattedValues": [],
            "RelatedEntities": [],
            "RowVersion": null,
            "KeyAttributes": []
          },
          {
            "LogicalName": "organization",
            "Id": "00000000-0000-0000-0000-000000000000",
            "Attributes": [
              {
                "Key": "IntervalStart",
                "Value": "2020-03-09T08:45:00Z"
              },
              {
                "Key": "ProposalResourceAssignments",
                "Value": {
                  "Entities": [
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "RequirementId",
                          "Value": "d64da763-c73e-4990-897c-f3293b731ced"
                        },
                        {
                          "Key": "ResourceId",
                          "Value": "bc095d77-fa68-4fa7-b80a-fcfb0fd32087"
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "RequirementId",
                          "Value": "6583cfba-e0d7-4997-b651-88f39c7edb94"
                        },
                        {
                          "Key": "ResourceId",
                          "Value": "12b9693b-793b-45b6-abd8-236ed0831ce5"
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "RequirementId",
                          "Value": "a80e4368-64d4-4d50-954c-0e6d8d7b8fb1"
                        },
                        {
                          "Key": "ResourceId",
                          "Value": "a0fd36d1-dcb0-41d1-968d-c5fa214702e7"
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    }
                  ],
                  "MoreRecords": false,
                  "PagingCookie": null,
                  "MinActiveRowVersion": "",
                  "TotalRecordCount": 0,
                  "TotalRecordCountLimitExceeded": false,
                  "EntityName": "organization"
                }
              }
            ],
            "EntityState": null,
            "FormattedValues": [],
            "RelatedEntities": [],
            "RowVersion": null,
            "KeyAttributes": []
          },
          {
            "LogicalName": "organization",
            "Id": "00000000-0000-0000-0000-000000000000",
            "Attributes": [
              {
                "Key": "IntervalStart",
                "Value": "2020-03-09T09:00:00Z"
              },
              {
                "Key": "ProposalResourceAssignments",
                "Value": {
                  "Entities": [
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "RequirementId",
                          "Value": "d64da763-c73e-4990-897c-f3293b731ced"
                        },
                        {
                          "Key": "ResourceId",
                          "Value": "69f8d921-10c7-4d6f-8bca-3345d36b21ca"
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "RequirementId",
                          "Value": "6583cfba-e0d7-4997-b651-88f39c7edb94"
                        },
                        {
                          "Key": "ResourceId",
                          "Value": "d8e264aa-af93-49ed-89e8-321e3a1d4abf"
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "RequirementId",
                          "Value": "a80e4368-64d4-4d50-954c-0e6d8d7b8fb1"
                        },
                        {
                          "Key": "ResourceId",
                          "Value": "34d67b43-8160-4573-b815-9ae24cd4d905"
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    }
                  ],
                  "MoreRecords": false,
                  "PagingCookie": null,
                  "MinActiveRowVersion": "",
                  "TotalRecordCount": 0,
                  "TotalRecordCountLimitExceeded": false,
                  "EntityName": "organization"
                }
              }
            ],
            "EntityState": null,
            "FormattedValues": [],
            "RelatedEntities": [],
            "RowVersion": null,
            "KeyAttributes": []
          },
          {
            "LogicalName": "organization",
            "Id": "00000000-0000-0000-0000-000000000000",
            "Attributes": [
              {
                "Key": "IntervalStart",
                "Value": "2020-03-09T09:15:00Z"
              },
              {
                "Key": "ProposalResourceAssignments",
                "Value": {
                  "Entities": [
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "RequirementId",
                          "Value": "d64da763-c73e-4990-897c-f3293b731ced"
                        },
                        {
                          "Key": "ResourceId",
                          "Value": "12b9693b-793b-45b6-abd8-236ed0831ce5"
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "RequirementId",
                          "Value": "6583cfba-e0d7-4997-b651-88f39c7edb94"
                        },
                        {
                          "Key": "ResourceId",
                          "Value": "6116cec7-e4ad-4d25-aa67-6aa029bcc30b"
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "RequirementId",
                          "Value": "a80e4368-64d4-4d50-954c-0e6d8d7b8fb1"
                        },
                        {
                          "Key": "ResourceId",
                          "Value": "34d67b43-8160-4573-b815-9ae24cd4d905"
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    }
                  ],
                  "MoreRecords": false,
                  "PagingCookie": null,
                  "MinActiveRowVersion": "",
                  "TotalRecordCount": 0,
                  "TotalRecordCountLimitExceeded": false,
                  "EntityName": "organization"
                }
              }
            ],
            "EntityState": null,
            "FormattedValues": [],
            "RelatedEntities": [],
            "RowVersion": null,
            "KeyAttributes": []
          },
          {
            "LogicalName": "organization",
            "Id": "00000000-0000-0000-0000-000000000000",
            "Attributes": [
              {
                "Key": "IntervalStart",
                "Value": "2020-03-09T09:30:00Z"
              },
              {
                "Key": "ProposalResourceAssignments",
                "Value": {
                  "Entities": [
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "RequirementId",
                          "Value": "d64da763-c73e-4990-897c-f3293b731ced"
                        },
                        {
                          "Key": "ResourceId",
                          "Value": "34d67b43-8160-4573-b815-9ae24cd4d905"
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "RequirementId",
                          "Value": "6583cfba-e0d7-4997-b651-88f39c7edb94"
                        },
                        {
                          "Key": "ResourceId",
                          "Value": "156be26c-fe0c-45c5-b1ed-591cb92f17a7"
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "RequirementId",
                          "Value": "a80e4368-64d4-4d50-954c-0e6d8d7b8fb1"
                        },
                        {
                          "Key": "ResourceId",
                          "Value": "62fd4fce-1f1e-4835-915e-fe67201234a2"
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    }
                  ],
                  "MoreRecords": false,
                  "PagingCookie": null,
                  "MinActiveRowVersion": "",
                  "TotalRecordCount": 0,
                  "TotalRecordCountLimitExceeded": false,
                  "EntityName": "organization"
                }
              }
            ],
            "EntityState": null,
            "FormattedValues": [],
            "RelatedEntities": [],
            "RowVersion": null,
            "KeyAttributes": []
          },
          {
            "LogicalName": "organization",
            "Id": "00000000-0000-0000-0000-000000000000",
            "Attributes": [
              {
                "Key": "IntervalStart",
                "Value": "2020-03-09T09:45:00Z"
              },
              {
                "Key": "ProposalResourceAssignments",
                "Value": {
                  "Entities": [
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "RequirementId",
                          "Value": "d64da763-c73e-4990-897c-f3293b731ced"
                        },
                        {
                          "Key": "ResourceId",
                          "Value": "34d67b43-8160-4573-b815-9ae24cd4d905"
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "RequirementId",
                          "Value": "6583cfba-e0d7-4997-b651-88f39c7edb94"
                        },
                        {
                          "Key": "ResourceId",
                          "Value": "69f8d921-10c7-4d6f-8bca-3345d36b21ca"
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "RequirementId",
                          "Value": "a80e4368-64d4-4d50-954c-0e6d8d7b8fb1"
                        },
                        {
                          "Key": "ResourceId",
                          "Value": "d97e6f62-ed34-4bbd-864e-e3f5b3e824cf"
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    }
                  ],
                  "MoreRecords": false,
                  "PagingCookie": null,
                  "MinActiveRowVersion": "",
                  "TotalRecordCount": 0,
                  "TotalRecordCountLimitExceeded": false,
                  "EntityName": "organization"
                }
              }
            ],
            "EntityState": null,
            "FormattedValues": [],
            "RelatedEntities": [],
            "RowVersion": null,
            "KeyAttributes": []
          },
          {
            "LogicalName": "organization",
            "Id": "00000000-0000-0000-0000-000000000000",
            "Attributes": [
              {
                "Key": "IntervalStart",
                "Value": "2020-03-09T10:00:00Z"
              },
              {
                "Key": "ProposalResourceAssignments",
                "Value": {
                  "Entities": [
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "RequirementId",
                          "Value": "d64da763-c73e-4990-897c-f3293b731ced"
                        },
                        {
                          "Key": "ResourceId",
                          "Value": "6116cec7-e4ad-4d25-aa67-6aa029bcc30b"
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "RequirementId",
                          "Value": "6583cfba-e0d7-4997-b651-88f39c7edb94"
                        },
                        {
                          "Key": "ResourceId",
                          "Value": "12b9693b-793b-45b6-abd8-236ed0831ce5"
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "RequirementId",
                          "Value": "a80e4368-64d4-4d50-954c-0e6d8d7b8fb1"
                        },
                        {
                          "Key": "ResourceId",
                          "Value": "ebb71951-70a6-4f47-8ebb-7ed66e95ef8d"
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    }
                  ],
                  "MoreRecords": false,
                  "PagingCookie": null,
                  "MinActiveRowVersion": "",
                  "TotalRecordCount": 0,
                  "TotalRecordCountLimitExceeded": false,
                  "EntityName": "organization"
                }
              }
            ],
            "EntityState": null,
            "FormattedValues": [],
            "RelatedEntities": [],
            "RowVersion": null,
            "KeyAttributes": []
          },
          {
            "LogicalName": "organization",
            "Id": "00000000-0000-0000-0000-000000000000",
            "Attributes": [
              {
                "Key": "IntervalStart",
                "Value": "2020-03-09T10:15:00Z"
              },
              {
                "Key": "ProposalResourceAssignments",
                "Value": {
                  "Entities": [
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "RequirementId",
                          "Value": "d64da763-c73e-4990-897c-f3293b731ced"
                        },
                        {
                          "Key": "ResourceId",
                          "Value": "617ec1ab-6e05-455b-a125-dab6f472106a"
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "RequirementId",
                          "Value": "6583cfba-e0d7-4997-b651-88f39c7edb94"
                        },
                        {
                          "Key": "ResourceId",
                          "Value": "156be26c-fe0c-45c5-b1ed-591cb92f17a7"
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "RequirementId",
                          "Value": "a80e4368-64d4-4d50-954c-0e6d8d7b8fb1"
                        },
                        {
                          "Key": "ResourceId",
                          "Value": "ebb71951-70a6-4f47-8ebb-7ed66e95ef8d"
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    }
                  ],
                  "MoreRecords": false,
                  "PagingCookie": null,
                  "MinActiveRowVersion": "",
                  "TotalRecordCount": 0,
                  "TotalRecordCountLimitExceeded": false,
                  "EntityName": "organization"
                }
              }
            ],
            "EntityState": null,
            "FormattedValues": [],
            "RelatedEntities": [],
            "RowVersion": null,
            "KeyAttributes": []
          },
          {
            "LogicalName": "organization",
            "Id": "00000000-0000-0000-0000-000000000000",
            "Attributes": [
              {
                "Key": "IntervalStart",
                "Value": "2020-03-09T10:30:00Z"
              },
              {
                "Key": "ProposalResourceAssignments",
                "Value": {
                  "Entities": [
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "RequirementId",
                          "Value": "d64da763-c73e-4990-897c-f3293b731ced"
                        },
                        {
                          "Key": "ResourceId",
                          "Value": "59178960-dca6-41fd-9681-c252a12d166e"
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "RequirementId",
                          "Value": "6583cfba-e0d7-4997-b651-88f39c7edb94"
                        },
                        {
                          "Key": "ResourceId",
                          "Value": "34d67b43-8160-4573-b815-9ae24cd4d905"
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "RequirementId",
                          "Value": "a80e4368-64d4-4d50-954c-0e6d8d7b8fb1"
                        },
                        {
                          "Key": "ResourceId",
                          "Value": "156be26c-fe0c-45c5-b1ed-591cb92f17a7"
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    }
                  ],
                  "MoreRecords": false,
                  "PagingCookie": null,
                  "MinActiveRowVersion": "",
                  "TotalRecordCount": 0,
                  "TotalRecordCountLimitExceeded": false,
                  "EntityName": "organization"
                }
              }
            ],
            "EntityState": null,
            "FormattedValues": [],
            "RelatedEntities": [],
            "RowVersion": null,
            "KeyAttributes": []
          },
          {
            "LogicalName": "organization",
            "Id": "00000000-0000-0000-0000-000000000000",
            "Attributes": [
              {
                "Key": "IntervalStart",
                "Value": "2020-03-09T10:45:00Z"
              },
              {
                "Key": "ProposalResourceAssignments",
                "Value": {
                  "Entities": [
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "RequirementId",
                          "Value": "d64da763-c73e-4990-897c-f3293b731ced"
                        },
                        {
                          "Key": "ResourceId",
                          "Value": "59178960-dca6-41fd-9681-c252a12d166e"
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "RequirementId",
                          "Value": "6583cfba-e0d7-4997-b651-88f39c7edb94"
                        },
                        {
                          "Key": "ResourceId",
                          "Value": "6116cec7-e4ad-4d25-aa67-6aa029bcc30b"
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "RequirementId",
                          "Value": "a80e4368-64d4-4d50-954c-0e6d8d7b8fb1"
                        },
                        {
                          "Key": "ResourceId",
                          "Value": "d97e6f62-ed34-4bbd-864e-e3f5b3e824cf"
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    }
                  ],
                  "MoreRecords": false,
                  "PagingCookie": null,
                  "MinActiveRowVersion": "",
                  "TotalRecordCount": 0,
                  "TotalRecordCountLimitExceeded": false,
                  "EntityName": "organization"
                }
              }
            ],
            "EntityState": null,
            "FormattedValues": [],
            "RelatedEntities": [],
            "RowVersion": null,
            "KeyAttributes": []
          },
          {
            "LogicalName": "organization",
            "Id": "00000000-0000-0000-0000-000000000000",
            "Attributes": [
              {
                "Key": "IntervalStart",
                "Value": "2020-03-09T11:00:00Z"
              },
              {
                "Key": "ProposalResourceAssignments",
                "Value": {
                  "Entities": [
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "RequirementId",
                          "Value": "d64da763-c73e-4990-897c-f3293b731ced"
                        },
                        {
                          "Key": "ResourceId",
                          "Value": "617ec1ab-6e05-455b-a125-dab6f472106a"
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "RequirementId",
                          "Value": "6583cfba-e0d7-4997-b651-88f39c7edb94"
                        },
                        {
                          "Key": "ResourceId",
                          "Value": "bc095d77-fa68-4fa7-b80a-fcfb0fd32087"
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "RequirementId",
                          "Value": "a80e4368-64d4-4d50-954c-0e6d8d7b8fb1"
                        },
                        {
                          "Key": "ResourceId",
                          "Value": "26592224-35eb-4215-b990-1d7f561d7edd"
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    }
                  ],
                  "MoreRecords": false,
                  "PagingCookie": null,
                  "MinActiveRowVersion": "",
                  "TotalRecordCount": 0,
                  "TotalRecordCountLimitExceeded": false,
                  "EntityName": "organization"
                }
              }
            ],
            "EntityState": null,
            "FormattedValues": [],
            "RelatedEntities": [],
            "RowVersion": null,
            "KeyAttributes": []
          },
          {
            "LogicalName": "organization",
            "Id": "00000000-0000-0000-0000-000000000000",
            "Attributes": [
              {
                "Key": "IntervalStart",
                "Value": "2020-03-09T11:15:00Z"
              },
              {
                "Key": "ProposalResourceAssignments",
                "Value": {
                  "Entities": [
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "RequirementId",
                          "Value": "d64da763-c73e-4990-897c-f3293b731ced"
                        },
                        {
                          "Key": "ResourceId",
                          "Value": "6116cec7-e4ad-4d25-aa67-6aa029bcc30b"
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "RequirementId",
                          "Value": "6583cfba-e0d7-4997-b651-88f39c7edb94"
                        },
                        {
                          "Key": "ResourceId",
                          "Value": "b2d3bc55-9c75-4447-ba7c-5336bd081cb1"
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "RequirementId",
                          "Value": "a80e4368-64d4-4d50-954c-0e6d8d7b8fb1"
                        },
                        {
                          "Key": "ResourceId",
                          "Value": "26592224-35eb-4215-b990-1d7f561d7edd"
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    }
                  ],
                  "MoreRecords": false,
                  "PagingCookie": null,
                  "MinActiveRowVersion": "",
                  "TotalRecordCount": 0,
                  "TotalRecordCountLimitExceeded": false,
                  "EntityName": "organization"
                }
              }
            ],
            "EntityState": null,
            "FormattedValues": [],
            "RelatedEntities": [],
            "RowVersion": null,
            "KeyAttributes": []
          },
          {
            "LogicalName": "organization",
            "Id": "00000000-0000-0000-0000-000000000000",
            "Attributes": [
              {
                "Key": "IntervalStart",
                "Value": "2020-03-09T11:30:00Z"
              },
              {
                "Key": "ProposalResourceAssignments",
                "Value": {
                  "Entities": [
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "RequirementId",
                          "Value": "d64da763-c73e-4990-897c-f3293b731ced"
                        },
                        {
                          "Key": "ResourceId",
                          "Value": "62fd4fce-1f1e-4835-915e-fe67201234a2"
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "RequirementId",
                          "Value": "6583cfba-e0d7-4997-b651-88f39c7edb94"
                        },
                        {
                          "Key": "ResourceId",
                          "Value": "bc095d77-fa68-4fa7-b80a-fcfb0fd32087"
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "RequirementId",
                          "Value": "a80e4368-64d4-4d50-954c-0e6d8d7b8fb1"
                        },
                        {
                          "Key": "ResourceId",
                          "Value": "b2d3bc55-9c75-4447-ba7c-5336bd081cb1"
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    }
                  ],
                  "MoreRecords": false,
                  "PagingCookie": null,
                  "MinActiveRowVersion": "",
                  "TotalRecordCount": 0,
                  "TotalRecordCountLimitExceeded": false,
                  "EntityName": "organization"
                }
              }
            ],
            "EntityState": null,
            "FormattedValues": [],
            "RelatedEntities": [],
            "RowVersion": null,
            "KeyAttributes": []
          },
          {
            "LogicalName": "organization",
            "Id": "00000000-0000-0000-0000-000000000000",
            "Attributes": [
              {
                "Key": "IntervalStart",
                "Value": "2020-03-09T11:45:00Z"
              },
              {
                "Key": "ProposalResourceAssignments",
                "Value": {
                  "Entities": [
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "RequirementId",
                          "Value": "d64da763-c73e-4990-897c-f3293b731ced"
                        },
                        {
                          "Key": "ResourceId",
                          "Value": "15722b27-facb-45e6-b262-afb30ed29382"
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "RequirementId",
                          "Value": "6583cfba-e0d7-4997-b651-88f39c7edb94"
                        },
                        {
                          "Key": "ResourceId",
                          "Value": "62fd4fce-1f1e-4835-915e-fe67201234a2"
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "RequirementId",
                          "Value": "a80e4368-64d4-4d50-954c-0e6d8d7b8fb1"
                        },
                        {
                          "Key": "ResourceId",
                          "Value": "617ec1ab-6e05-455b-a125-dab6f472106a"
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    }
                  ],
                  "MoreRecords": false,
                  "PagingCookie": null,
                  "MinActiveRowVersion": "",
                  "TotalRecordCount": 0,
                  "TotalRecordCountLimitExceeded": false,
                  "EntityName": "organization"
                }
              }
            ],
            "EntityState": null,
            "FormattedValues": [],
            "RelatedEntities": [],
            "RowVersion": null,
            "KeyAttributes": []
          },
          {
            "LogicalName": "organization",
            "Id": "00000000-0000-0000-0000-000000000000",
            "Attributes": [
              {
                "Key": "IntervalStart",
                "Value": "2020-03-09T12:00:00Z"
              },
              {
                "Key": "ProposalResourceAssignments",
                "Value": {
                  "Entities": [
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "RequirementId",
                          "Value": "d64da763-c73e-4990-897c-f3293b731ced"
                        },
                        {
                          "Key": "ResourceId",
                          "Value": "b2d3bc55-9c75-4447-ba7c-5336bd081cb1"
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "RequirementId",
                          "Value": "6583cfba-e0d7-4997-b651-88f39c7edb94"
                        },
                        {
                          "Key": "ResourceId",
                          "Value": "59178960-dca6-41fd-9681-c252a12d166e"
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "RequirementId",
                          "Value": "a80e4368-64d4-4d50-954c-0e6d8d7b8fb1"
                        },
                        {
                          "Key": "ResourceId",
                          "Value": "15722b27-facb-45e6-b262-afb30ed29382"
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    }
                  ],
                  "MoreRecords": false,
                  "PagingCookie": null,
                  "MinActiveRowVersion": "",
                  "TotalRecordCount": 0,
                  "TotalRecordCountLimitExceeded": false,
                  "EntityName": "organization"
                }
              }
            ],
            "EntityState": null,
            "FormattedValues": [],
            "RelatedEntities": [],
            "RowVersion": null,
            "KeyAttributes": []
          },
          {
            "LogicalName": "organization",
            "Id": "00000000-0000-0000-0000-000000000000",
            "Attributes": [
              {
                "Key": "IntervalStart",
                "Value": "2020-03-09T12:15:00Z"
              },
              {
                "Key": "ProposalResourceAssignments",
                "Value": {
                  "Entities": [
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "RequirementId",
                          "Value": "d64da763-c73e-4990-897c-f3293b731ced"
                        },
                        {
                          "Key": "ResourceId",
                          "Value": "d8e264aa-af93-49ed-89e8-321e3a1d4abf"
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "RequirementId",
                          "Value": "6583cfba-e0d7-4997-b651-88f39c7edb94"
                        },
                        {
                          "Key": "ResourceId",
                          "Value": "12b9693b-793b-45b6-abd8-236ed0831ce5"
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "RequirementId",
                          "Value": "a80e4368-64d4-4d50-954c-0e6d8d7b8fb1"
                        },
                        {
                          "Key": "ResourceId",
                          "Value": "6116cec7-e4ad-4d25-aa67-6aa029bcc30b"
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    }
                  ],
                  "MoreRecords": false,
                  "PagingCookie": null,
                  "MinActiveRowVersion": "",
                  "TotalRecordCount": 0,
                  "TotalRecordCountLimitExceeded": false,
                  "EntityName": "organization"
                }
              }
            ],
            "EntityState": null,
            "FormattedValues": [],
            "RelatedEntities": [],
            "RowVersion": null,
            "KeyAttributes": []
          },
          {
            "LogicalName": "organization",
            "Id": "00000000-0000-0000-0000-000000000000",
            "Attributes": [
              {
                "Key": "IntervalStart",
                "Value": "2020-03-09T12:30:00Z"
              },
              {
                "Key": "ProposalResourceAssignments",
                "Value": {
                  "Entities": [
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "RequirementId",
                          "Value": "d64da763-c73e-4990-897c-f3293b731ced"
                        },
                        {
                          "Key": "ResourceId",
                          "Value": "12b9693b-793b-45b6-abd8-236ed0831ce5"
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "RequirementId",
                          "Value": "6583cfba-e0d7-4997-b651-88f39c7edb94"
                        },
                        {
                          "Key": "ResourceId",
                          "Value": "a0fd36d1-dcb0-41d1-968d-c5fa214702e7"
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "RequirementId",
                          "Value": "a80e4368-64d4-4d50-954c-0e6d8d7b8fb1"
                        },
                        {
                          "Key": "ResourceId",
                          "Value": "d97e6f62-ed34-4bbd-864e-e3f5b3e824cf"
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    }
                  ],
                  "MoreRecords": false,
                  "PagingCookie": null,
                  "MinActiveRowVersion": "",
                  "TotalRecordCount": 0,
                  "TotalRecordCountLimitExceeded": false,
                  "EntityName": "organization"
                }
              }
            ],
            "EntityState": null,
            "FormattedValues": [],
            "RelatedEntities": [],
            "RowVersion": null,
            "KeyAttributes": []
          },
          {
            "LogicalName": "organization",
            "Id": "00000000-0000-0000-0000-000000000000",
            "Attributes": [
              {
                "Key": "IntervalStart",
                "Value": "2020-03-09T12:45:00Z"
              },
              {
                "Key": "ProposalResourceAssignments",
                "Value": {
                  "Entities": [
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "RequirementId",
                          "Value": "d64da763-c73e-4990-897c-f3293b731ced"
                        },
                        {
                          "Key": "ResourceId",
                          "Value": "b2d3bc55-9c75-4447-ba7c-5336bd081cb1"
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "RequirementId",
                          "Value": "6583cfba-e0d7-4997-b651-88f39c7edb94"
                        },
                        {
                          "Key": "ResourceId",
                          "Value": "6116cec7-e4ad-4d25-aa67-6aa029bcc30b"
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "RequirementId",
                          "Value": "a80e4368-64d4-4d50-954c-0e6d8d7b8fb1"
                        },
                        {
                          "Key": "ResourceId",
                          "Value": "34d67b43-8160-4573-b815-9ae24cd4d905"
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    }
                  ],
                  "MoreRecords": false,
                  "PagingCookie": null,
                  "MinActiveRowVersion": "",
                  "TotalRecordCount": 0,
                  "TotalRecordCountLimitExceeded": false,
                  "EntityName": "organization"
                }
              }
            ],
            "EntityState": null,
            "FormattedValues": [],
            "RelatedEntities": [],
            "RowVersion": null,
            "KeyAttributes": []
          },
          {
            "LogicalName": "organization",
            "Id": "00000000-0000-0000-0000-000000000000",
            "Attributes": [
              {
                "Key": "IntervalStart",
                "Value": "2020-03-09T13:00:00Z"
              },
              {
                "Key": "ProposalResourceAssignments",
                "Value": {
                  "Entities": [
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "RequirementId",
                          "Value": "d64da763-c73e-4990-897c-f3293b731ced"
                        },
                        {
                          "Key": "ResourceId",
                          "Value": "bc095d77-fa68-4fa7-b80a-fcfb0fd32087"
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "RequirementId",
                          "Value": "6583cfba-e0d7-4997-b651-88f39c7edb94"
                        },
                        {
                          "Key": "ResourceId",
                          "Value": "b2d3bc55-9c75-4447-ba7c-5336bd081cb1"
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    },
                    {
                      "LogicalName": "organization",
                      "Id": "00000000-0000-0000-0000-000000000000",
                      "Attributes": [
                        {
                          "Key": "RequirementId",
                          "Value": "a80e4368-64d4-4d50-954c-0e6d8d7b8fb1"
                        },
                        {
                          "Key": "ResourceId",
                          "Value": "62fd4fce-1f1e-4835-915e-fe67201234a2"
                        }
                      ],
                      "EntityState": null,
                      "FormattedValues": [],
                      "RelatedEntities": [],
                      "RowVersion": null,
                      "KeyAttributes": []
                    }
                  ],
                  "MoreRecords": false,
                  "PagingCookie": null,
                  "MinActiveRowVersion": "",
                  "TotalRecordCount": 0,
                  "TotalRecordCountLimitExceeded": false,
                  "EntityName": "organization"
                }
              }
            ],
            "EntityState": null,
            "FormattedValues": [],
            "RelatedEntities": [],
            "RowVersion": null,
            "KeyAttributes": []
          }
        ],
        "MoreRecords": false,
        "PagingCookie": null,
        "MinActiveRowVersion": "",
        "TotalRecordCount": 0,
        "TotalRecordCountLimitExceeded": false,
        "EntityName": "organization"
      }
    },
    {
      "Key": "PagingInfos",
      "Value": {
        "LogicalName": "organization",
        "Id": "00000000-0000-0000-0000-000000000000",
        "Attributes": [
          {
            "Key": "MoreResults",
            "Value": true
          },
          {
            "Key": "PagingCookie",
            "Value": "{\"nte\":\"3.2.1\",\"nti\":\"2020-03-09T13:00:00.0000000Z\",\"res\":{\"nfr\":20,\"nft\":20,\"rbd\":{\"2020-03-09T08:15:00.0000000Z\":{\"cpl\":1,\"nfr\":1,\"nft\":1,\"tic\":null,\"tid\":null},\"2020-03-09T08:30:00.0000000Z\":{\"cpl\":1,\"nfr\":1,\"nft\":1,\"tic\":null,\"tid\":null},\"2020-03-09T08:45:00.0000000Z\":{\"cpl\":1,\"nfr\":1,\"nft\":1,\"tic\":null,\"tid\":null},\"2020-03-09T09:00:00.0000000Z\":{\"cpl\":1,\"nfr\":1,\"nft\":1,\"tic\":null,\"tid\":null},\"2020-03-09T09:15:00.0000000Z\":{\"cpl\":1,\"nfr\":1,\"nft\":1,\"tic\":null,\"tid\":null},\"2020-03-09T09:30:00.0000000Z\":{\"cpl\":1,\"nfr\":1,\"nft\":1,\"tic\":null,\"tid\":null},\"2020-03-09T09:45:00.0000000Z\":{\"cpl\":1,\"nfr\":1,\"nft\":1,\"tic\":null,\"tid\":null},\"2020-03-09T10:00:00.0000000Z\":{\"cpl\":1,\"nfr\":1,\"nft\":1,\"tic\":null,\"tid\":null},\"2020-03-09T10:15:00.0000000Z\":{\"cpl\":1,\"nfr\":1,\"nft\":1,\"tic\":null,\"tid\":null},\"2020-03-09T10:30:00.0000000Z\":{\"cpl\":1,\"nfr\":1,\"nft\":1,\"tic\":null,\"tid\":null},\"2020-03-09T10:45:00.0000000Z\":{\"cpl\":1,\"nfr\":1,\"nft\":1,\"tic\":null,\"tid\":null},\"2020-03-09T11:00:00.0000000Z\":{\"cpl\":1,\"nfr\":1,\"nft\":1,\"tic\":null,\"tid\":null},\"2020-03-09T11:15:00.0000000Z\":{\"cpl\":1,\"nfr\":1,\"nft\":1,\"tic\":null,\"tid\":null},\"2020-03-09T11:30:00.0000000Z\":{\"cpl\":1,\"nfr\":1,\"nft\":1,\"tic\":null,\"tid\":null},\"2020-03-09T11:45:00.0000000Z\":{\"cpl\":1,\"nfr\":1,\"nft\":1,\"tic\":null,\"tid\":null},\"2020-03-09T12:00:00.0000000Z\":{\"cpl\":1,\"nfr\":1,\"nft\":1,\"tic\":null,\"tid\":null},\"2020-03-09T12:15:00.0000000Z\":{\"cpl\":1,\"nfr\":1,\"nft\":1,\"tic\":null,\"tid\":null},\"2020-03-09T12:30:00.0000000Z\":{\"cpl\":1,\"nfr\":1,\"nft\":1,\"tic\":null,\"tid\":null},\"2020-03-09T12:45:00.0000000Z\":{\"cpl\":1,\"nfr\":1,\"nft\":1,\"tic\":null,\"tid\":null},\"2020-03-09T13:00:00.0000000Z\":{\"cpl\":1,\"nfr\":1,\"nft\":1,\"tic\":null,\"tid\":null}}}}"
          }
        ],
        "EntityState": null,
        "FormattedValues": [],
        "RelatedEntities": [],
        "RowVersion": null,
        "KeyAttributes": []
      }
    }
  ]
}
```

<a name="bkmk_crgb"></a>

## Create Requirement Group Bookings API

Use the following input and output parameters for the Create Requirement Group Bookings (**msdyn_CreateRequirementGroupBookings**) API.

### Input parameters
<!--I don't understand the following table. What is the middle column supposed to represent here? The last four rows look like they're items in a nested list, but I don't know what to nest the list under. -->
|            |   |         |
|----------------------------------|---|---------|
|Version (String)                  |   |Required |
|RequirementGroup (EntityReference)|   |Required |
|Start (DateTime)                  |   |Required |
|Duration (Int)                    |   |Required |
|ResourceAssignments (EntityCollection)|Requirement (Guid)|Required|
|<li> Resource (Guid)                  | |Required|
|<li> BookingStatusID (Guid)           | |Required|
|<li> Effort (Int)                     | |Required|
|<li> TravelTime (double)              | |Required|

### Output parameters

HandlerExecuted (Boolean)

## Using the Requirement Group API
<!--I'm afraid I don't understand what the goal of this entire section is.-->
In the following scenario, you schedule a requirement group via API. You'll need a service created with resources before you can schedule a booking. Follow these steps to create a service activity.

### Service configuration 

![Service configuration ](media/ur-scheduling-1-new.png "Service configuration")

  1. In the site map, under **Scheduling**, select **Service**.
  2. Go to **Resource Requirements**.
  3. Create a service activity. For this example, we've created **Test Requirement Group**.

### Service Activity configuration  

![Service Activity configuration](media/ur-scheduling-2-new.png "Service Activity configuration")

  1. In the site map, under **Scheduling**, select **Service Activities**.
  5. Go to **Service Activities**.
  6. For **Subject**, select **Test Requirement Group**.
  7. For **Service**, select **Test Requirement Group**.

> [!NOTE]
> This automatically creates a resource requirement group that has the same name as the service activity. 

Now you have a requirement group automatically created that has one technician (resource) to be scheduled to perform service at your customer's location. 

### Resource Requirement Group grid 
<!--Steps 1 and 2 seem to be captions or alt text for the graphics, rather than steps. If they are actually steps, can you rewrite them so the goal is clear?-->
The following image is an example configuration of the Resource Requirement Group page. 

![Active Requirements Group](media/ur-scheduling-3-new.png "Active Requirements Group")

<!--1. Active Requirements Group-->

 > [!NOTE] 
 > To access the **Requirement Group** page from the Customer Service Hub app, you need to navigate there via a URL. 

> [!IMPORTANT]
> Use the following URL to reach the **Resource Requirements Group** page: <<YourOrgURL>YourOrgURL>?appid=guid&pagetype=entitylist&etn=msdyn_requirementgroupr.

<!--2. Test Requirements Group-->

![Test Requirements Group](media/ur-scheduling-4-new.png "Test Requirements Group")
<!--I don't know the UI well enough to edit this procedure. Can you rewrite it so it follows our style guide? -->
3. Go to **General**.
4. Name field **Test Requirement Group**.
5. Enter name in **Owner** field.
6. Template field.
7. Template Required, select **No**.

### Search against your organization

In this next scenario, we show how to pass values for a specific requirement group (Entity Reference - GUID), Required Resources<!--what is this?--> to complete work and match the resource to the organizational unit.      

> [!IMPORTANT] 
> - To run the API<!--are we still talking about the Requirement Group API?-->, you need GUIDs for:
>   - Requirement group
>   - Bookable resources
>   - Organizational unit (which can be retrieved by using the [Web API](/powerapps/developer/common-data-service/webapi/query-metadata-web-api))
> - If the API is called from a client (browser or canvas app) based on JavaScript, you need to have the extended SOAP SDK. The extended SOAP SDK is not an official Microsoft release, but you can is provided in the downloadable sample files for guidance. 
> - We recommend that you test this search in your development or test environments to validate your scenarios and results before running it in your production environment.

To execute this search against your organization, you need to download the [sample files](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/customer-service/service-scheduling/search-resource-availability-create-bookings), and then follow the steps below:   

1. Modify the hard-coded input parameters in the msdyn_SearchResourceAvailabilityForRequirementGroupSample.js file to reflect the GUIDs of records in your org. (Example: requirement group, resources, organizational unit).    
<!--Can you rewrite the alt text for the following graphics? It shouldn't all be the same. It should describe what's unique and useful about the graphic.-->
![Modify the hard-coded input parameters](media/ur-scheduling-5.PNG)

[Sample Search Requirement Group](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/sushant-service-scheduling/customer-service/master/search-resource-availability-create-bookings)

2. Add the files in the sample folder as web resources in your organization 

![Modify the hard-coded input parameters](media/ur-scheduling-6-new.png)

![Modify the hard-coded input parameters](media/ur-scheduling-7-new.PNG)

3. Navigate to the newly added new_msdyn_SearchResourceAvailabilityForRequirementGroupSample.htm page. Example: <<YourOrgURL>>//WebResources/new_msdyn_SearchResourceAvailabilityForRequirementGroupSample.htm   

![Modify the hard-coded input parameters](media/ur-scheduling-8.PNG)

4. Open the browser's developer tools by using the F12 function key. Set breakpoints as needed, and inspect the request/responses in the developer tool's console.  

![Modify the hard-coded input parameters](media/ur-scheduling-9.PNG)

  We can see there are multiple sets of time slots that are returned with each Set corresponding to a matching available Resource mapped to the underlying Requirement of the Requirement Group.   

  After the time slot Sets are returned by the API, you can display them on your custom web portal, app, or a Power App (model/canvas).    

5. After you choose a specific time slot set (Set number 1 in this example), update your new_msdyn_CreateRequirementGroupBookingsSample.js web resource in your org to pass the Resource Assignments (Requirement guid, Resource guid) and the Requirement Group as shown in the example below:    

![Modify the hard-coded input parameters](media/ur-scheduling-10-new.PNG)

> [!IMPORTANT]
> Find the complete sample code here: [Create Requirement Group](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/customer-service/service-scheduling/search-resource-availability-create-bookings).

![Modify the hard-coded input parameters](media/ur-scheduling-11-new.png)

6. Navigate to the newly added new_ msdyn_CreateRequirementGroupBookingsSample.htm page. (Example: <<YourOrgURL>>//WebResources/new_msdyn_CreateRequirementGroupBookingsSample.htm) to invoke a call to the Booking API and create the booking.

![Modify the hard-coded input parameters](media/ur-scheduling-12.png)

7. Open the browser's developer tools by using the F12 function key. Here you'll see that the Handler executed value is set to True, indicating that the bookings were created successfully.    

![Modify the hard-coded input parameters](media/ur-scheduling-13.png)

  We can also verify this by going back into the organization and checking the associated bookings of the Service/Requirement group we created, as shown in the following illustrations.    

![Modify the hard-coded input parameters](media/ur-scheduling-14-new.png)

![Modify the hard-coded input parameters](media/ur-scheduling-15-new.png)

Other possible scenarios that might leverage these APIs are:   
- Build a custom web app or a Dynamics 365 portal to provide appointment scheduling for users. The app will show available time slots for the service or product being offered by using multiresource requirements (requirement groups).
- Build a Power App canvas app to support self-scheduling scenarios for line-of-business apps.    

## Additional resources  

- Multiresource scheduling with [requirement groups](https://docs.microsoft.com/dynamics365/common-scheduler/multi-resource-scheduling-requirement-groups)
   
- Search Resource Availability API for [single resource requirements](https://cloudblogs.microsoft.com/dynamics365/it/2019/07/15/how-to-use-resource-schedulings-search-resource-availability-api/)   

- Overview of [Dynamics 365 for Field Service](https://docs.microsoft.com/dynamics365/field-service/overview) <!--Edit to the URL okay?-->

- Documentation for [resource scheduling](https://docs.microsoft.com/dynamics365/customer-engagement/common-scheduler/schedule-anything-with-universal-resource-scheduling)  

- [Learning path](https://docs.microsoft.com/learn/paths/universal-resource-scheduling/) for resource scheduling

- [Field Service YouTube Channel](https://www.youtube.com/playlist?list=PLcakwueIHoT_AQBxkQQ7zePzd7fzZYP7X)

- [Dynamics 365 application ideas](https://experience.dynamics.com/ideas/categories/list/?category=a2fa5aca-3f2d-e811-813c-e0071b6ad011&forum=bee3d862-df65-e811-a95d-000d3a1be7ad) portal where you can contribute product feedback and ideas for resource scheduling 

- [Forum](https://community.dynamics.com/365/fieldservice) where you can ask questions, find answers, and see upcoming events 

- The [Dynamics 365 blog](https://cloudblogs.microsoft.com/dynamics365/?s=Resource+Scheduling), which has ongoing release notes and posts from the product team   
<!--The following information is redundant:
- The post [How to use Resource Scheduling’s Search Resource Availability API](https://cloudblogs.microsoft.com/dynamics365/it/2019/07/15/how-to-use-resource-schedulings-search-resource-availability-api/) appeared first on [Dynamics 365 Blog](https://cloudblogs.microsoft.com/dynamics365).-->   

<!--Can you say what the following sample code snippet can be used for? It's kind of just floating here.-->
### Sample code snippet

```csharp
void Main()  
{   
// Authentication   
String machineName = "aurorav?????";   
String orgName = "CITTest";   
String domain = $"{machineName}dom.extest.microsoft.com";   
String uri = $"http://{machineName}.{domain}/{orgName}/XRMServices/2011/Organization.svc";   
String username = "administrator";   
String password = "";

// Connect to organization
Microsoft.Pfe.Xrm.OrganizationServiceManager osm = new
Microsoft.Pfe.Xrm.OrganizationServiceManager(new Uri(@uri), username, password, domain);

searchResourceAvailabilityForRequirementGroup(osm);  
createRequirementGroupBookings(osm);  
}   

void searchResourceAvailabilityForRequirementGroup(OrganizationServiceManager osm) 
{
var req = new OrganizationRequest()
{
RequestName = "msdyn_SearchResourceAvailabilityForRequirementGroup"
};  

//Version  
req["Version"] = "1.0.0";
req["RequirementGroup"] = new EntityReference("msdyn_requirementgroup", Guid.Parse(""));

var response = osm.GetProxy().Execute(req);
}   

void createRequirementGroupBookings(OrganizationServiceManager osm)
{
var req = new OrganizationRequest()
{   
RequestName = "msdyn_createRequirementGroupBookings"
};   
 
//Version
req["Version"] = "1.0.0";
req["RequirementGroup"] = new EntityReference("msdyn_requirementgroup", 
Guid.Parse("d723dd8f-f4f4-e911-a81d-000d3af9eba2"));
req["Start"] = DateTime.Today.AddDays(1);
req["Duration"] = 60;
EntityCollection resourceAssignment = new EntityCollection();
var entity = new Entity();
entity["RequirementId"] = "";
entity["ResourceId"] = "";
entity["BookingStatusId"] = "";
resourceAssignment.Add(entity); 
req["ResourceAssignment"] = resourceAssignment;   

var response = osm.GetProxy().Execute(req); 
}  
```

## How to migrate from the legacy API to Universal Resource Scheduling 

To migrate from the legacy Search API and Book API to the Universal Resource Scheduling API, use the following required input and output fields to map the APIs. 

### Input mapping data for the Search API 
<!--I assume the blank cells in this table indicate that there is no equivalent API input in legacy or URS? Can you put something like "None" in the table cells that are currently blank? Then it would look like they're blank intentionally. -->
|Legacy input |Universal Resource Scheduling input |Description| 
|-------------|----------|-----------|
|ServiceId    |Requirement group  |Service/requirement group GUID|
|SearchWindowStart|Start date  |Start date for the appointment search |
|SearchWindowEnd   |End date |End date for the appointment search |
|Duration  |Duration  |Appointment duration |
|No of results  |Page size |Total number of proposals or number of appointments on a page |
|Sites  |OrganizationUnits  |Site/OU GUID |
|RequiredResource  |Preferred Resources|Resources the customer prefers to schedule |
|Constraints |Constraints |Customer entity(ufx)<!--what is "ufx"? --> |
|RecurrenceDuration     |                     |In a recurrence appointment search, the duration of the appointment |
|RecurrenceTimeZoneCode |                     |Time zone for a recurring request        |
|SearchDirection        |                     |Forward or backward search for slots, based on the dates given |
|AnchorOffSet           |                     |Offset in hours from midnight             |
|UserTimeZoneCode       |                     |Time zone that's been set for the user    | 
|SearchRecurrenceRule   |                     |Frequency, interval, count and so on      | 
|                       |Resource Types       |Type of resource                          |
|                       |Restricted Resources |Restricted for scheduling the appointment |

###  Output mapping for the Search API 

|Legacy output |Universal Resource Scheduling output |
|--------------|-----------|
|Appointment proposals |ProposalsResourceAssignmentSet |
|TraceInfo | |
|ExtensionDataObject | | 
|   |Time Slots|
|   |Requirements(contraintbag)<!--what is this?--> |
|   |PagingInfos |

## Example scenarios for migrating from the legacy API to Universal Resource Scheduling

The scenario-based examples in this section add more details about mapping from the legacy API to the new Universal Resource Scheduling API.   
<!--It won't work for these scenario headings to mention the legacy screenshot. I suggest giving the scenarios meaningful names (please double-check the names I've given) and just introduce the screenshot as part of the introduction to each scenario.-->
### Scenario 1: Get two resources for each schedule proposal  

*The following screenshot from the legacy API is provided for reference in this scenario.*

![Legacy setup screenshot for reference for scenario 1](media/ur-scheduling-16-new.png "Legacy screenshot for reference for scenario 1")

1. Create one site (**Site1**), one user (**User1**), and one equipment resource (**Facility/Equipment** tab)<!--is this what "facility/equipment" means? --> (**Eq1**) with the site set to Site1. 

2. Create the business closure and work hours for the user (8:00 AM to 6:00 PM) and the equipment (8:00 AM to 6:00 PM). 

3. Create a new service (**Service1**), and then add **required resources** as **Choose 2** from User1, Eq1.<!--I'm confused about what's going on in this sentence. Please check that these are actually UI strings (and if they aren't, please supply the UI in bold.--> Save and close the service. <!--Should the following alt text say "Schedule Service Activity"? That seems to be the name of the page. -->

![Service Activity screenshot for scenario 1](media/ur-scheduling-17-new.png "Service Activity screenshot for scenario 1")

4. Go to the homepage<!--it doesn't actually say "homepage" on the homepage, does it? If it does, then it does call for bold formatting. --> > **Service Activity**<!--or **Schedule Service Activity**?-->, select **Service1** <!--edit okay? I assume you select the service you just created and named Service1?-->, and then select **Schedule** > **Find available slots**. 

5. Verify that two resources are returned for each proposal in accordance with the criteria you set.  

#### Universal Resource Scheduling API code for scenario 1 

```csharp
void searchRequirementgroup(Microsoft.Pfe.Xrm.OrganizationServiceManager osm)
{ 
var req = new Microsoft.Xrm.Sdk.OrganizationRequest() 
{ 
RequestName = "msdyn_SearchResourceAvailabilityForRequirementGroup"
};

  req["Version"] = "1.0.0"; 
  Entity requirementSpecification = new Entity();

  //Setting from date 

  requirementSpecification.Attributes.Add("msdyn_fromdate", DateTime.Parse("2019-12-  
  26T18:30:00.000Z"));

  //Setting to date 

  requirementSpecification.Attributes.Add("msdyn_todate", DateTime.Parse("2019-12- 
  27T18:29:00.000Z"));

  //Requirement group GUID 
  req["RequirementSpecification"] = requirementSpecification; 
  req["RequirementGroup"] = new   
  Microsoft.Xrm.Sdk.EntityReference("msdyn_requirementgroup", Guid.Parse("XXXXXXXX"));

  //Executing the request and getting response
  var response = osm.GetProxy().Execute(req); 
  response.ToString(); 
  response.Dump();
} 	 
```

### Scenario 2: Verify that search results are correct for scheduling 

*The following screenshot from the legacy API is provided for reference in this scenario.* 

![Legacy setup screenshot for reference for scenario 2](media/ur-scheduling-18-new.png "Legacy setup screenshot for reference for scenario 2")
<!--In step 4, please check that the correct formatting is applied to UI strings. (Specifically, is "Search for a specific start and end time" the name of the command? If so, the whole string should be bold.) -->
1. Create the following: 
  - Two sites: Micr0s0ftSite1 and Site2
  - Two users: User1 and User2 (Site2)
  - Two equipment resources on the **Facility/Equipment** tab<!--Is this correct for the UI string? --> (Eq1, Eq2), where Eq1 belongs to Site1 and Eq2 belongs to Site2
 
2. Create the business closure and work hours for the user (8:00 AM to 6:00 PM) and the equipment (8:00 AM to 6:00 PM). 

3. Create a new service with status **Reserved** and required resources as **Choose 2** from **same site** from User1, User2, Eq1, Eq2. Save and close the service. 

![Service Activity screenshot for scenario 2](media/ur-scheduling-19-new.png "Service Activity screenshot for scenario 2")

4. Go to the homepage > **Service Activity** > **Schedule**, and then select the service you created in step 3. Select the site as **Site1**, and then select **Search for a specific start and end time**<!--is this the UI string? If not, please adjust the formatting. -->. 

5. Verify that the search results that are returned are correct for the site selected in the search criteria.<!--is this what "per the site" means? --> 

#### Universal Resource Scheduling API code for scenario 2

```csharp
void searchRequirementgroup(Microsoft.Pfe.Xrm.OrganizationServiceManager osm)
{
  var req = new Microsoft.Xrm.Sdk.OrganizationRequest()
  {
  RequestName = "msdyn_SearchResourceAvailabilityForRequirementGroup"
  };
req["Version"] = "1.0.0"; 
Entity requirementSpecification = new Entity();

//Setting from date
requirementSpecification.Attributes.Add("msdyn_fromdate", DateTime.Parse("2019-12-26T18:30:00.000Z"));

//Setting to date
requirementSpecification.Attributes.Add("msdyn_todate", DateTime.Parse("2019-12-27T18:29:00.000Z")); 

//Setting up the Site as filter criteria for search.	      
requirementSpecification.Attributes.Add("msdyn_organizationalunit",Guid.Parse("XXXXXXXXXXXX")); 

req["RequirementSpecification"] = requirementSpecification;

//Requirement group GUID      
req["RequirementGroup"] = new EntityReference("msdyn_requirementgroup", Guid.Parse("XXXXXX"));

var response = osm.GetProxy().Execute(req);
response.ToString();
response.Dump();

}
```

### Scenario 3: Get proposed schedules that occur within the working hours for an equipment resource

![Legacy setup screenshot for reference for scenario 3](media/ur-scheduling-20-new.png "Legacy setup screenshot for reference for scenario 3")

1. Create two sites (Site1, Site2), and then create three equipment resources (Eq1, Eq2, Eq3). 

2. Create the business closure and work hours for all equipment (3:00 PM to 6:00 PM). 

3. Create a new service (**Service1**) Choose 1 from (Random) Eq1, Eq2, #q3 <!--I don't know what the UI says, so I can't suggest the correct formatting for "Choose 1 from (Random)." -->

![Service Activity screenshot for scenario 3](media/ur-scheduling-21-new.png "Service Activity screenshot for scenario 3")

4. In the **Schedule Service Activity** dialog box, search for proposals for Service1 by adding a required resource as **Eq1** for a specific date range. 

5. Verify that the proposed schedules that are returned occur within the working hours of the equipment for that date. 

#### Universal Resource Scheduling API code for scenario 3

```csharp
void searchRequirementgroup(Microsoft.Pfe.Xrm.OrganizationServiceManager osm)
{
var req = new Microsoft.Xrm.Sdk.OrganizationRequest() 
{
RequestName = "msdyn_SearchResourceAvailabilityForRequirementGroup"
};
req["Version"] = "1.0.0"; 
Entity requirementSpecification = new Entity();

//Setting start date          
requirementSpecification.Attributes.Add("msdyn_fromdate", DateTime.Parse("2019-12-26T18:30:00.000Z"));
//Setting end date
requirementSpecification.Attributes.Add("msdyn_todate", DateTime.Parse("2019-12-27T18:29:00.000Z"));

//Setting the eq1 as required resource	 	

requirementSpecification.Attributes.Add("msdyn_resourcerequirementid",Guid.Parse("XXXXXX")); 
req["RequirementSpecification"] = requirementSpecification; 

//Setting the requirement group GUID
req["RequirementGroup"] = new EntityReference("msdyn_requirementgroup", Guid.Parse("XXXXX"));

//Executing the request and getting response. 
var response = osm.GetProxy().Execute(req); 
response.ToString(); 
response.Dump(); 
} 
```

### See also

[Service Scheduling Guide](basics-service-service-scheduling.md)  
[Service scheduling FAQ](service-scheduling-faq.md)