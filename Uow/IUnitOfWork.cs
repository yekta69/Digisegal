using Digisegal.Models.Segal_DbContext;
using Digisegal.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Digisegal.Uow
{
        public interface IUnitOfWork : IDisposable
        {

            int Complete();
           SegalDbContext GetDbContext();
            IUserRepository UserRepository { get; }
            //ICommitmentRepository CommitmentRepository { get; }
            //IFamilyRelationshipRepository familyRelationshipRepository { get; }
            //ICityRepository CityRepository { get; }
            //IBankRepository BankRepository { get; }
            //IGroupRepository GroupRepository { get; }
            //IPackageRepository PackageRepository { get; }
            //IUserRegionRepository UserRegionRepository { get; }
            //IRegionRepository RegionRepository { get; }
            //IUserGroupRepository UserGroupRepository { get; }
            //IGroupRegionRepository GroupRegionRepository { get; }
            //IPackageRepository packageRepository { get; }
            //IAccountingRulesRepository AccountingRulesRepository { get; }
            //IWorkFlowRepository WorkFlowRepository { get; }
            //IWorkFlowStepRepository WorkFlowStepRepository { get; }
            //IBankWarningRepository bankWarningRepository { get; }
            //ICheckoutRepository CheckoutRepository { get; }
            //IEmployeeDetailsRepository EmployeeDetailsRepository { get; }
            //IReferRepository referRepository { get; }
        }
    }

