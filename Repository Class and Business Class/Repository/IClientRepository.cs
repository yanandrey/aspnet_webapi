﻿using APIRest_ASPNET5.Models;
using System.Collections.Generic;

namespace APIRest_ASPNET5.Repository
{
    public interface IClientRepository
    {
        Client Create(Client client);

        Client FindById(long id);

        List<Client> FindAll();

        Client Update(Client client);

        void Delete(long id);

        bool Exists(long id);
    }
}
