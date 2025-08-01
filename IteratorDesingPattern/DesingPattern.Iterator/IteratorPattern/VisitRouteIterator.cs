namespace DesingPattern.Iterator.IteratorPattern
{
    public class VisitRouteIterator : IIterator<VisitRoute>
    {
        private VisitRouteMover _visit;

        public VisitRouteIterator(VisitRouteMover visit)
        {
            _visit = visit;
        }

        private int currentIndex = 0;


        public VisitRoute CurrentItem {get; set;}

        public bool NextLocation()
        {
            if (currentIndex<_visit.VisitRouteCount)
            {
                CurrentItem = _visit.visitRoutes[currentIndex++];
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
