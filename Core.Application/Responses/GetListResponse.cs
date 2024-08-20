﻿using Core.Persistence.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Responses;

public class GetListResponse<T> :BasePageableModel
{
    public IList<T> _items;

    public IList<T> Items
    {
        get => _items??=new List<T>();
        set => _items = value;
    }
}
