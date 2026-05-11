namespace Coordinates;

public class LineOfReflection
{
    /*
     Given a list of 2D point coordinates, determine if a symmetrical vertical line x=a exists and return the value of that vertical line.
E.g:

[(1, 3), (2, 5), (3, 5), (4,3)] has a symmetrical line x=2.5
[(1, 3), (2, 5), (3, 5), (4, 2)] does not have a symmetrical line however
     */

    public record Point (int X, int Y);

    public bool LineOfReflectionExists(List<Point> points) 
    { 
        if(points.Count <= 0) 
            return false;

        Point max = new(0, 0);
        Point min = new(0, 0);
        HashSet<Point> coords = new();

        foreach (Point point in points) 
        { 
            if(point.X > max.X)
                max = point;
            if(point.X < min.X)
                min = point;

            coords.Add(point);
        }

        int xVert = (max.X + min.X) / 2;

        foreach (Point point in points) 
        {
            int distToVert = point.X - xVert;
            int symmetricX = xVert - distToVert;

            Point symmetricPoint = new(symmetricX, point.Y);
            if (!coords.Contains(symmetricPoint)) 
            { 
                return false;
            }
        }

        return true;
    }


    /*
    def is_possbile(coords: list[tuple[int, int]]) -> bool:
    if len(coords) <= 1:
        return True

    coords_set = set()
    max_c = (float('-inf'), float ('-inf'))
    min_c = (float('inf'), float ('inf'))
    for x, y in coords:
        if max_c[0] < x:
            max_c = (x, y)
        if min_c[0] > x:
            min_c = (x, y)

        coords_set.add((x, y))

    x_vert = (max_c[0] + min_c[0]) / 2

    for x, y in coords:
        dist_to_vert = x - x_vert

        symmetric_x = int(x_vert - dist_to_vert)

        if (symmetric_x, y) not in coords_set:
            return False

    return True
    */
}
