using Digisegal.Models.Segal_DbContext;
using Digisegal.Repositories;
using Digisegal.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Linq;


namespace Digisegal.Uow
{


    public class UnitOfWork : IUnitOfWork
    {
        private readonly StoreSegalDbContext _context;
        public UnitOfWork(StoreSegalDbContext context)
        {
            _context = context;
            UserRepository = new UserRepository(_context);
            OrdersRepository = new OrdersRepository(_context);
            ProductRepository = new ProductRepository(_context);
            OrganRepository = new OrganRepository(_context);
            ContactUsRepository = new ContactUsRepository(_context);
            AboutUsRepository = new AboutUsRepository(_context);
            AmazingOfferRepository = new AmazingOfferRepository(_context);
            RoleRepository = new RoleRepository(_context);


            //CommitmentRepository = new CommitmentRepository(_context);
            //familyRelationshipRepository = new FamilyRelationshipRepository(_context);
            //CityRepository = new CityRepository(_context);
            //BankRepository = new BankRepository(_context);
            //GroupRepository = new GroupRepository(_context);
            //PackageRepository = new PackageRepository(_context);
            //UserRegionRepository = new UserRegionRepository(_context);
            //RegionRepository = new RegionRepository(_context);
            //UserGroupRepository = new UserGroupRepository(_context);
            //GroupRegionRepository = new GroupRegionRepository(_context);
            //packageRepository = new PackageRepository(_context);
            //AccountingRulesRepository = new AccountingRulesRepository(_context);
            //WorkFlowRepository = new WorkFlowRpository(_context);
            //WorkFlowStepRepository = new WorkFlowStepRpository(_context);
            //bankWarningRepository = new BankWarningRepository(_context);
            //CheckoutRepository = new CheckoutRepository(_context);
            //EmployeeDetailsRepository = new EmployeeDetailsRepository(_context);
            //referRepository = new ReferRepository(_context);
        }



        public IUserRepository UserRepository { get; }
        public IOrdersRepository OrdersRepository { get; }
        public IProductRepository ProductRepository { get; }
        public IOrganRepository OrganRepository { get; }
        public IContactUsRepository ContactUsRepository { get; }
        public IAboutUsRepository AboutUsRepository { get; }
        public IAmazingOfferRepository AmazingOfferRepository { get; }
        public IRoleRepository RoleRepository { get; }
        //public ICommitmentRepository CommitmentRepository { get; }
        //public IFamilyRelationshipRepository familyRelationshipRepository { get; }
        //public ICityRepository CityRepository { get; }
        //public IBankRepository BankRepository { get; }

        //public IGroupRepository GroupRepository { get; }

        //public IPackageRepository PackageRepository { get; }

        //public IPackageRepository packageRepository { get; }

        //public IUserRegionRepository UserRegionRepository { get; }

        //public IRegionRepository RegionRepository { get; }

        //public IUserGroupRepository UserGroupRepository { get; }

        //public IGroupRegionRepository GroupRegionRepository { get; }

        //public IAccountingRulesRepository AccountingRulesRepository { get; }

        //public IWorkFlowRepository WorkFlowRepository { get; }

        //public IWorkFlowStepRepository WorkFlowStepRepository { get; }

        //public IBankWarningRepository bankWarningRepository { get; }

        //public ICheckoutRepository CheckoutRepository { get; }

        //public IEmployeeDetailsRepository EmployeeDetailsRepository { get; }
        //public IReferRepository referRepository { get; }
        // public ISpecialWorkflowRepository SpecialWorkflowRepository { get; }

        public int Complete()
        {
            try
            {
                var entities = from e in _context.ChangeTracker.Entries()
                               where e.State == EntityState.Added
                                   || e.State == EntityState.Modified
                               select e.Entity;
                foreach (var entity in entities)
                {
                    var validationContext = new ValidationContext(entity);
                    Validator.ValidateObject(entity, validationContext);
                }

                return _context.SaveChanges();
            }
            catch (ValidationException ex)
            {
                return -1;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public StoreSegalDbContext GetDbContext()
        {
            return _context;
        }
    }
}
