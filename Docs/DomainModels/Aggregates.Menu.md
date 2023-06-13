# Domain Models

## Menu

```csharp
class Menu
{
    Menu create();
    void AddDinner(Dinner dinner);
    void RemoveDinner(Dinner dinner);
    void UpdateSection(MenuSection section);
}
```

```json
{
  "id": "000000-0000-000000",
  "name": "",
  "description": "",
  "averageRating": 4.5,
  "sections": [
    {
      "id": "",
      "name": "",
      "description": "",
      "items": [
        {
          "id": "",
          "name": "",
          "description": "",
          "price": 10.9
        }
      ]
    }
  ],
  "createdDateTime": "",
  "updatedDateTime": "",
  "hostId": "000000-0000-000000",
  "dinnerIds": ["000000-0000-000000", "000000-0000-000000"],
  "menuReviewIds": ["000000-0000-000000", "000000-0000-000000"]
}
```
