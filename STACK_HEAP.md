# Stack & Heap — Order Reference Example

The following diagrams show what happens step by step when working with the `Order` class.

---

## Diagram 1 — After Line 1

```text
Order o1 = new Order
{
    OrderId = 1,
    CustomerName = "Ali"
};


+----------------------+       +-----------------------------+
|       STACK          |       |            HEAP             |
|                      |       |                             |
| o1                   |       |  Address: 0x001             |
| ┌──────────────┐     |       |  ┌───────────────────────┐  |
| │ 0x001        │─────┼──────►|  │ Order                 │  |
| └──────────────┘     |       |  │                       │  |
|                      |       |  │ OrderId = 1           │  |
|                      |       |  │ CustomerName = "Ali"  │  |
|                      |       |  │ Quantity = 0          │  |
|                      |       |  │ UnitPrice = 0         │  |
|                      |       |  │ TotalPrice = 0        │  |
|                      |       |  │ IsPaid = false        │  |
|                      |       |  │ DiscountPercent = 0   │  |
|                      |       |  │ ShippingCity = null   │  |
|                      |       |  │ Priority = '\0'       │  |
|                      |       |  │ ItemCode = 0          │  |
|                      |       |  └───────────────────────┘  |
+----------------------+       +-----------------------------+
```

**Explanation:** `o1` is a reference stored on the stack that points to one `Order` object on the heap.

---

## Diagram 2 — After Line 2

```text
Order o2 = o1;


+----------------------+       +-----------------------------+
|       STACK          |       |            HEAP             |
|                      |       |                             |
| o1                   |       |  Address: 0x001             |
| ┌──────────────┐     |       |  ┌───────────────────────┐  |
| │ 0x001        │─────┼──────►|  │ Order                 │  |
| └──────────────┘     |       |  │                       │  |
|                      |       |  │ OrderId = 1           │  |
| o2                   |       |  │ CustomerName = "Ali"  │  |
| ┌──────────────┐     |       |  │ Quantity = 0          │  |
| │ 0x001        │─────┼──────►|  │ UnitPrice = 0         │  |
| └──────────────┘     |       |  │ TotalPrice = 0        │  |
|                      |       |  │ IsPaid = false        │  |
|                      |       |  │ DiscountPercent = 0   │  |
|                      |       |  │ ShippingCity = null   │  |
|                      |       |  │ Priority = '\0'       │  |
|                      |       |  │ ItemCode = 0          │  |
|                      |       |  └───────────────────────┘  |
+----------------------+       +-----------------------------+
```

**Explanation:** `o2` receives the same reference as `o1`, so both variables point to the same `Order` object.

---

## Diagram 3 — After Line 3

```text
o2.IsPaid = true;


+----------------------+       +-----------------------------+
|       STACK          |       |            HEAP             |
|                      |       |                             |
| o1                   |       |  Address: 0x001             |
| ┌──────────────┐     |       |  ┌───────────────────────┐  |
| │ 0x001        │─────┼──────►|  │ Order                 │  |
| └──────────────┘     |       |  │                       │  |
|                      |       |  │ OrderId = 1           │  |
| o2                   |       |  │ CustomerName = "Ali"  │  |
| ┌──────────────┐     |       |  │ Quantity = 0          │  |
| │ 0x001        │─────┼──────►|  │ UnitPrice = 0         │  |
| └──────────────┘     |       |  │ TotalPrice = 0        │  |
|                      |       |  │ IsPaid = true         │  |
|                      |       |  │ DiscountPercent = 0   │  |
|                      |       |  │ ShippingCity = null   │  |
|                      |       |  │ Priority = '\0'       │  |
|                      |       |  │ ItemCode = 0          │  |
|                      |       |  └───────────────────────┘  |
+----------------------+       +-----------------------------+
```

**Explanation:** `o2.IsPaid = true` changes the same heap object, so the change is visible through both `o1` and `o2`.

---

# What would be different with structs?

If `Order` were a `struct` instead of a `class`, it would be a value type.

For example, with the `Point` struct from Part C:

```text
Point p1 = new Point { X = 1, Y = 2 };
Point p2 = p1;
```

The assignment copies the value itself.

```text
+----------------------+       +----------------------+
|       STACK          |       |       STACK           |
|                      |       |                      |
| p1                   |       | p2                   |
| ┌──────────────┐     |       | ┌──────────────┐      |
| │ X = 1        │     |       | │ X = 1        │      |
| │ Y = 2        │     |       | │ Y = 2        │      |
| └──────────────┘     |       | └──────────────┘      |
+----------------------+       +----------------------+
```

After:

```csharp
p2.X = 99;
```

`p1.X` remains `1`, while `p2.X` becomes `99`, because `p1` and `p2` contain separate copies of the value.
