const std = @import("std");

pub fn main() !void {
    const val = read_only_memory.lookup_table[3];
    const allocator = std.heap.page_allocator;

    const scores = try allocator.alloc(i32, 3);

    scores[0] = 100;
    scores[1] = 90;
    scores[2] = 80;

    for (scores) |score| {
        std.debug.print("Score: {}\n", .{score});
    }

    allocator.free(scores);
}
