class Injector{
    
    public Injector(){
        initDataBaseConnect();
        postDependencies();
    }

    private void initDataBaseConnect(){
        Database.getInstance();
    }

    private void postDependencies(){
        Navigator.getInstance().buildRoot();
    }
}