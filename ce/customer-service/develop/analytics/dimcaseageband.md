---
title: DimCaseAgeBand table reference
description: Reference the model-only DimCaseAgeBand table, its nonoverlapping age bands, sort order, and snapshot relationship.
ms.date: 10/30/2026
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ai-usage: ai-assisted
---

# DimCaseAgeBand table reference

Use `DimCaseAgeBand` to display active-case age groups in the correct order in backlog charts and matrices.


## Columns

| Column | Model type | Description |
|---|---|---|
| `AgeBandCode` | STRING | Primary key matching the code on `AggCaseSnapshot`. |
| `AgeBandLabel` | STRING | Age-band display label, sorted by `SortOrder`. |
| `SortOrder` | INT64 | Display order, from youngest to oldest. |

## Age-band values

Age measures elapsed time from case creation to capture, not business days or time since the last update.

| AgeBandCode | AgeBandLabel | SortOrder | Elapsed age |
|---|---|---|---|
| `D0_1` | 0-1 day | 1 | Less than 2 days. |
| `D2_7` | 2-7 days | 2 | At least 2 days and less than 8 days. |
| `D8_30` | 8-30 days | 3 | At least 8 days and less than 31 days. |
| `D31_89` | 31-89 days | 4 | At least 31 days and less than 90 days. |
| `D90Plus` | 90+ days | 5 | At least 90 days. |
| `NotActive` | Not active | 6 | Case isn't active, or its age is unavailable. |

The bands don't overlap. A case exactly 31 days old belongs to `D31_89`. At exactly 90 days, it belongs to `D90Plus`.

## Dashboard relationships

Use age bands to filter and group backlog in `AggCaseSnapshot`. They don't filter case performance in `AggCaseAnalytics` or SLA results in `AggCaseSLA`.

The age chart and queue-by-age matrix exclude inactive cases (`NotActive`). At the next refresh, a case might move to an older age band, but it remains grouped by its original creation date.

## Related information

[AggCaseSnapshot](aggcasesnapshot.md)   
[Case metrics reference](../../use/case-metrics.md)   
