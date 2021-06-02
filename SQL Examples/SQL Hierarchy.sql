
WITH Hierarchy AS (
  -- "Root" node(s)
  SELECT DISTINCT 1 AS Level, PST.PST_CompItemID AS PackId, PST.PST_ParentItemID AS ParentID, PST.PST_CompItemID AS SystemId, IMA.IMA_Classification AS Classification
  FROM PST
  INNER JOIN IMA ON PST.PST_CompItemID = IMA.IMA_ItemID
  WHERE PST_CompItemID IN ('150192', '150222', '150177', '150176', '150241', '150233', '150203', '150206')
  AND PST_ParentItemID NOT LIKE 'Q%'

  UNION ALL

  -- "Child" node(s)
  SELECT 1+Level, PackId, PST.PST_ParentItemID, PST.PST_CompItemID, IMA.IMA_Classification
  FROM Hierarchy
  INNER JOIN PST ON PST_CompItemID = ParentID AND PST_ParentItemID NOT LIKE 'Q%'
  INNER JOIN IMA ON PST.PST_CompItemID = IMA.IMA_ItemID
)

SELECT SystemId, PackId
FROM Hierarchy
WHERE Classification = 'Base Builds'